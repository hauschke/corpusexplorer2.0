﻿#region

using System.Net;
using CorpusExplorer.Sdk.Ecosystem.Model;
using CorpusExplorer.Sdk.Model;
using CorpusExplorer.Sdk.Model.Cache;
using CorpusExplorer.Sdk.Model.Cache.Abstract;
using CorpusExplorer.Sdk.Terminal;

#endregion

namespace CorpusExplorer.Sdk.Ecosystem
{
  public static class CorpusExplorerEcosystem
  {
    public static TerminalController CurrentTerminalController { get;private set; }
    public static Project CurrentProject => CurrentTerminalController?.Project;

    /// <summary>
    ///   Initialisiert ein vollständiges CorpusExplorer-Ökosystem.
    /// </summary>
    /// <param name="cacheStrategy">
    ///   Erlaubt es das Block-Caching-Verhalten zu ändern. Für Initialize(null) ist
    ///   CacheStrategyCurrentSelection festgelegt.
    /// </param>
    /// <param name="alternative3rdPartyPath">
    ///   Normalerweise wird nur im Pfad der aktuellen EXEcutable nach 3rd-Party-Addons gesucht.
    ///   Mit diesem Parameter kann ein anderer Ordner als Suchpfad angegeben werden.
    /// </param>
    /// <returns>TerminalController - erlaubt das Verwalten von Projekten</returns>
    public static TerminalController Initialize(AbstractCacheStrategy cacheStrategy = null,
                                                string alternative3rdPartyPath = null)
    {
      SslFix();
      Configuration.Initialize(InitialOptionsEnum.MinimalAnd3rdParty, alternative3rdPartyPath: alternative3rdPartyPath);
      Configuration.Cache = cacheStrategy ?? new CacheStrategyCurrentSelection();
      var res = new TerminalController();
      res.ProjectNew();

      CurrentTerminalController = res;

      return res;
    }

    /// <summary>
    ///   Initialisiert ein minimales CorpusExplorer-Ökosystem.
    ///   Erlaubt keine Projektverwaltung
    /// </summary>
    /// <param name="cacheStrategy">
    ///   Erlaubt es das Block-Caching-Verhalten zu ändern. Für InitializeMinimal(null) ist
    ///   CacheStrategyDisableCaching festgelegt.
    /// </param>
    /// <param name="alternative3rdPartyPath">
    ///   Normalerweise wird nur im Pfad der aktuellen EXEcutable nach 3rd-Party-Addons gesucht.
    ///   Mit diesem Parameter kann ein anderer Ordner als Suchpfad angegeben werden.
    /// </param>
    /// <returns>Project</returns>
    public static Project InitializeMinimal(AbstractCacheStrategy cacheStrategy = null,
                                            string alternative3rdPartyPath = null)
    {
      SslFix();
      Configuration.Initialize(InitialOptionsEnum.Minimal, alternative3rdPartyPath: alternative3rdPartyPath);
      Configuration.Cache = cacheStrategy ?? new CacheStrategyDisableCaching();
      var res = new TerminalController();
      res.ProjectNew();

      CurrentTerminalController = CurrentTerminalController;

      return res.Project;
    }

    private static void SslFix()
    {
      try
      {
        ServicePointManager.Expect100Continue = true;
        ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
      }
      catch
      {
        // ignore
      }
    }
  }
}
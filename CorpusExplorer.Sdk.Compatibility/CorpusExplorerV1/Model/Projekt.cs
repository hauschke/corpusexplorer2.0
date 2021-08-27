#region usings

using System;
using System.Collections.Generic;
using System.Linq;
using CorpusExplorer.Sdk.Data.Model.MetaInformationen;
using CorpusExplorer.Sdk.Data.Model.Statistik.Signifikanz;

#endregion

namespace CorpusExplorer.Sdk.Data.Model
{
  /// <summary>
  ///   Class Projekt
  /// </summary>
  [Serializable]
  public class Projekt
  {
    /// <summary>
    ///   The _korpus namen
    /// </summary>
    private readonly List<string> _korpusNamen = new List<string>();

    /// <summary>
    ///   The _arbeits layer
    /// </summary>
    [NonSerialized] private ArbeitsLayer _arbeitsLayer;

    /// <summary>
    ///   The _korpora
    /// </summary>
    [NonSerialized] private List<MultiLayer> _korpora;

    private bool _useLayer2Only = true;

    /// <summary>
    ///   Initializes a new instance of the <see cref="Projekt" /> class.
    /// </summary>
    public Projekt()
    {
      SignifikanzMa� = new PoissonSignifikanz();

      Reload();
    }

    /// <summary>
    ///   Ma� das die Signifikanz berechnet
    /// </summary>
    public ISignifikanz SignifikanzMa� { get; set; }

    /// <summary>
    ///   Gibt einen Prototypen f�r alle Dokumente zur�ck
    /// </summary>
    public Dictionary<string, Type> DokumentMetadatenPrototyp
    {
      get
      {
        var res = new Dictionary<string, Type>();

        foreach (
          var x in from k in _korpora from x in k.MetadatenDokumentPrototyp where !res.ContainsKey(x.Name) select x)
          res.Add(x.Name, x.InternValue.GetType());

        return res;
      }
    }

    /// <summary>
    ///   Gets the arbeits layer.
    /// </summary>
    /// <value>The arbeits layer.</value>
    public ArbeitsLayer ArbeitsLayer
    {
      get
      {
        if (_arbeitsLayer != null)
          return _arbeitsLayer;

        BuildArbeitslayer();

        return _arbeitsLayer;
      }
    }

    /// <summary>
    ///   Gets or sets the ausgew�hlte dokumente.
    /// </summary>
    /// <value>The ausgew�hlte dokumente.</value>
    public IEnumerable<string> Ausgew�hlteDokumente
    {
      get { return (from k in _korpora from d in k.IsSelecedDocument select d); }
    }

    /// <summary>
    ///   Gets or sets the ausgew�hlte korpora.
    /// </summary>
    /// <value>The ausgew�hlte korpora.</value>
    public IEnumerable<string> Ausgew�hlteKorpora
    {
      get { return Korpora.Select(k => k.KorpusName); }
    }

    /// <summary>
    ///   Gets the korpora.
    /// </summary>
    /// <value>The korpora.</value>
    public List<MultiLayer> Korpora
    {
      get { return _korpora; }
      private set { _korpora = value; }
    }

    /// <summary>
    ///   Gets the verf�gbare dokumente.
    /// </summary>
    /// <value>The verf�gbare dokumente.</value>
    public IEnumerable<string> Verf�gbareDokumente
    {
      get { return Korpora.SelectMany(korpus => korpus.DokumentNamensListe); }
    }

    /// <summary>
    ///   Gets the verf�gbare korpora.
    /// </summary>
    /// <value>The verf�gbare korpora.</value>
    public IEnumerable<string> Verf�gbareKorpora
    {
      get { return Korpora.Select(k => k.KorpusName); }
    }

    public bool UseLayer2Only
    {
      get
      {
        return this._useLayer2Only;
      }
      set
      {
        this._useLayer2Only = value;
      }
    }

    /// <summary>
    ///   Aggregiert die Metadaten aller MultiLayer
    /// </summary>
    /// <returns>Metadaten</returns>
    public Dictionary<string, List<AbstrakterMetaEintrag>> AggregateDokumentMetadata()
    {
      var res = new Dictionary<string, List<AbstrakterMetaEintrag>>();
      foreach (var y in from x in _korpora from y in x.MetadatenDokumente where !res.ContainsKey(y.Key) select y)
        res.Add(y.Key, y.Value);
      return res;
    }

    /// <summary>
    ///   Gibt die Metadaten eines bestimmten Dokuments zur�ck.
    /// </summary>
    /// <param name="dokumentName">Dokument</param>
    /// <returns></returns>
    public List<AbstrakterMetaEintrag> FindDokumentMetaDaten(string dokumentName)
    {
      return
        _korpora.Where(k => k.MetadatenDokumente.ContainsKey(dokumentName))
          .Select(k => k.MetadatenDokumente[dokumentName])
          .FirstOrDefault();
    }

    /// <summary>
    ///   Occurs when [arbeits layer ver�ndert].
    /// </summary>
    public event EventHandler ArbeitsLayerVer�ndert;

    /// <summary>
    ///   Adds the specified korpus.
    /// </summary>
    /// <param name="korpus">The korpus.</param>
    public void Add(MultiLayer korpus)
    {
      _korpusNamen.Add(korpus.KorpusName);
      Korpora.Add(korpus);
    }

    /// <summary>
    ///   Called when [arbeits layer ver�ndert].
    /// </summary>
    private void OnArbeitsLayerVer�ndert()
    {
      _arbeitsLayer = null;
      if (ArbeitsLayerVer�ndert != null)
        ArbeitsLayerVer�ndert(ArbeitsLayer, null);
    }

    /// <summary>
    ///   Reloads this instance.
    /// </summary>
    public void Reload()
    {
      Korpora = new List<MultiLayer>();

      foreach (var kn in _korpusNamen)
      {
        var multi = new MultiLayer(kn);
        Add(multi);
      }
    }

    /// <summary>
    ///   W�hles the dokument.
    /// </summary>
    /// <param name="dokumente">The dokumente.</param>
    public void W�hleDokumentToggle(string dokumente)
    {
      foreach (var k in _korpora)
        if (k.IsSelecedDocument.Contains(dokumente))
          k.IsSelecedDocument.Remove(dokumente);
        else
          k.IsSelecedDocument.Add(dokumente);

      OnArbeitsLayerVer�ndert();
    }

    /// <summary>
    ///   W�hles the dokumente alle.
    /// </summary>
    /// <param name="strings">The strings.</param>
    public void W�hleDokumenteAlle(IEnumerable<string> strings)
    {
      foreach (var d in strings)
        foreach (var k in _korpora.Where(k => !k.IsSelecedDocument.Contains(d)))
          k.IsSelecedDocument.Add(d);

      OnArbeitsLayerVer�ndert();
    }

    /// <summary>
    ///   W�hles the dokumente keine.
    /// </summary>
    /// <param name="strings">The strings.</param>
    public void W�hleDokumenteKeine(IEnumerable<string> strings)
    {
      foreach (var d in strings)
        foreach (var k in _korpora.Where(k => k.IsSelecedDocument.Contains(d)))
          k.IsSelecedDocument.Remove(d);

      _arbeitsLayer = null;
    }

    /// <summary>
    ///   W�hles the korpora alle.
    /// </summary>
    /// <param name="strings">The strings.</param>
    public void W�hleKorporaAlle(IEnumerable<string> strings)
    {
      foreach (var k in _korpora)
        k.IsSelected = true;

      OnArbeitsLayerVer�ndert();
    }

    /// <summary>
    ///   W�hles the korpora keine.
    /// </summary>
    /// <param name="strings">The strings.</param>
    public void W�hleKorporaKeine(IEnumerable<string> strings)
    {
      foreach (var k in _korpora)
        k.IsSelected = false;

      OnArbeitsLayerVer�ndert();
    }

    /// <summary>
    ///   W�hles the korpus.
    /// </summary>
    /// <param name="korpus">The korpus.</param>
    public void W�hleKorpusToggle(string korpus)
    {
      var k = _korpora.Find(x => x.KorpusName == korpus);
      if (k == null)
        return;

      k.IsSelected = !k.IsSelected;

      OnArbeitsLayerVer�ndert();
    }

    /// <summary>
    ///   Builds the arbeitslayer.
    /// </summary>
    private void BuildArbeitslayer()
    {
      _arbeitsLayer = new ArbeitsLayer(Ausgew�hlteKorpora);
      foreach (
        var korpus in
          Ausgew�hlteKorpora.Select(k => Korpora.Find(x => x.KorpusName == k)).Where(korpus => korpus != null))
      {
        _arbeitsLayer.Add(korpus.CloneLimmited(Ausgew�hlteDokumente) as MultiLayer);
      }

      _arbeitsLayer.LimmitLayer(Ausgew�hlteDokumente);
    }
  }
}
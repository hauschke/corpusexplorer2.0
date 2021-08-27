#region usings

using System.Collections.Generic;
using System.Linq;
using CorpusExplorer.Sdk.Data.Helper;

#endregion

namespace CorpusExplorer.Sdk.Data.Model
{
  /// <summary>
  ///   Class <see cref="ArbeitsLayer" />
  /// </summary>
  public class ArbeitsLayer : MultiLayer
  {
    /// <summary>
    ///   The <see cref="CorpusExplorer.Sdk.Data.Model.ArbeitsLayer._changes" />
    /// </summary>
    private readonly Dictionary<string, MultiLayer> _changes = new Dictionary<string, MultiLayer>();

    /// <summary>
    ///   Initializes a new instance of the <see cref="ArbeitsLayer" /> class.
    /// </summary>
    /// <param name="korpora">The korpora.</param>
    public ArbeitsLayer(IEnumerable<string> korpora)
    {
      foreach (var k in korpora)
      {
        if (string.IsNullOrEmpty(k)) continue;
        _changes.Add(k, new MultiLayer(k));
      }
    }

    /// <summary>
    ///   Gets the korpora.
    /// </summary>
    /// <value>
    ///   The korpora.
    /// </value>
    public MultiLayer[] Korpora
    {
      get { return _changes.Select(change => change.Value).ToArray(); }
    }

    /// <summary>
    ///   Gets the korpora namen.
    /// </summary>
    /// <value>
    ///   The korpora namen.
    /// </value>
    public IEnumerable<string> KorporaNamen
    {
      get { return _changes.Select(change => change.Key).ToArray(); }
    }

    /*
    /// <summary>
    ///   Gets the statistik.
    /// </summary>
    /// <value>
    ///   The statistik.
    /// </value>
    public SuchStatistik Statistik
    {
      get
      {
        var res = new SuchStatistik();
        return SafetyExecute.Run(() =>
                                   {
                                     var wort = this["Wort"];
                                     var lemma = this["Lemma"];

                                     double wg = wort.W�rterGesamtzahl;
                                     double sl = wort.SatzAnazahl;
                                     var wM = wg/sl;
                                     var wS =
                                       Math.Sqrt(
                                         wort._dokumente.SelectMany(d => d.Value)
                                             .Sum(satz => Math.Pow(satz.Length - wM, 2))/sl);

                                     var aAu = 0;
                                     var aRu = 0;
                                     var aZe = 0;
                                     var aPu = 0;
                                     var dMin = DateTime.MaxValue;
                                     var dMax = DateTime.MinValue;

                                     aAu = Z�hleMetaangaben(wort, ref aAu, ref dMax, ref dMin, ref aPu,
                                                            ref aRu, ref aZe);

                                     res = new SuchStatistik
                                             {
                                               Dokumente = wort.DokumentenAnzahl,
                                               Lemmata = lemma.DatenAnzahl,
                                               Wortformen = wort.DatenAnzahl,
                                               W�rter = (int) wg,
                                               S�tze = (int) sl,
                                               W�rterProSatzMittelwert = wM,
                                               W�rterProSatzStandardabweichung = wS,
                                               AnzahlAutoren = aAu,
                                               ZeitraumVon = dMin,
                                               ZeitraumBis = dMax,
                                               AnzahlZeitungen = aZe,
                                               AnzahlRubriken = aRu,
                                               AnzahlPublikationen = aPu
                                             };

                                     return res;
                                   }, res);
      }
    }
    */

    /// <summary>
    ///   Dokumentens the <paramref name="wert" /> modifizieren.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="dokumentName">Name of the dokument.</param>
    /// <param name="satzIndex">Index of the satz.</param>
    /// <param name="wortIndex">Index of the wort.</param>
    /// <param name="wert">The wert.</param>
    public void DokumentenWertModifizieren(string layerName, string dokumentName, int satzIndex, int wortIndex,
      int wert)
    {
      foreach (var korpusName in KorporaNamen)
      {
        if (!_changes.ContainsKey(korpusName))
          _changes.Add(korpusName, new MultiLayer(korpusName));

        DokumentenWertModifizierenCall(layerName, dokumentName, satzIndex, wortIndex, wert,
          _changes[korpusName]);

        var alt = this[layerName];
        _layers.Add(DokumentenWertModifizierenCall(layerName, dokumentName, satzIndex, wortIndex,
          wert, this));
        _layers.Remove(alt);
      }
    }

    /// <summary>
    ///   Flushes the changes.
    /// </summary>
    public void FlushChanges()
    {
      foreach (var pair in _changes)
      {
        pair.Value.Save();
      }
    }

    /// <summary>
    ///   Layers the hinzuf�gen.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    public void LayerHinzuf�gen(string layerName)
    {
      foreach (var korpusName in KorporaNamen)
      {
        if (!_changes.ContainsKey(korpusName))
          _changes.Add(korpusName, new MultiLayer(korpusName));

        var layer = _changes[korpusName]["Wort"];
        var res = Layer2.Create(layerName, new ListOptimized<string> {""},
          LayerHinzuf�gen_LeerDokumenteErzeugen(layer));

        _changes[korpusName].Add(res, true);
        _layers.Add(res);
      }
    }

    /// <summary>
    ///   Layerwerts the �ndern.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="layerWertAlt">The layer wert alt.</param>
    /// <param name="layerWertNeu">The layer wert neu.</param>
    public void Layerwert�ndern(string layerName, string layerWertAlt, string layerWertNeu)
    {
      foreach (var korpusName in KorporaNamen)
      {
        if (!_changes.ContainsKey(korpusName))
          _changes.Add(korpusName, new MultiLayer(korpusName));

        Layerwert�ndernCall(layerName, layerWertAlt, layerWertNeu, _changes[korpusName]);

        var alt = this[layerName];
        _layers.Add(Layerwert�ndernCall(layerName, layerWertAlt, layerWertNeu, this));
        _layers.Remove(alt);
      }
    }

    /// <summary>
    ///   Layerwerts the hinzuf�gen.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="layerWert">The layer wert.</param>
    public void LayerwertHinzuf�gen(string layerName, string layerWert)
    {
      foreach (var korpusName in KorporaNamen)
      {
        if (!_changes.ContainsKey(korpusName))
          _changes.Add(korpusName, new MultiLayer(korpusName));

        LayerwertHinzuf�genCall(layerName, layerWert, _changes[korpusName]);

        var alt = this[layerName];
        _layers.Add(LayerwertHinzuf�genCall(layerName, layerWert, this));
        _layers.Remove(alt);
      }
    }

    /// <summary>
    ///   Layerwerts the l�schen.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="layerWert">The layer wert.</param>
    public void LayerwertL�schen(string layerName, string layerWert)
    {
      foreach (var korpusName in KorporaNamen)
      {
        if (!_changes.ContainsKey(korpusName))
          _changes.Add(korpusName, new MultiLayer(korpusName));

        LayerwertL�schenCall(layerName, layerWert, _changes[korpusName]);

        var alt = this[layerName];
        _layers.Add(LayerwertL�schenCall(layerName, layerWert, this));
        _layers.Remove(alt);
      }
    }

    /// <summary>
    ///   Limmits the layer.
    /// </summary>
    /// <param name="ausgew�hlteDokumente">The ausgew�hlte dokumente.</param>
    public void LimmitLayer(IEnumerable<string> ausgew�hlteDokumente)
    {
      _dokumentNamensListe = ausgew�hlteDokumente.AsParallel().ToArray();
    }

    /// <summary>
    ///   Layers the hinzuf�gen_ leer dokumente erzeugen.
    /// </summary>
    /// <param name="layer">The layer.</param>
    /// <returns>
    ///   Dictionary{System.StringSystem.Int32[][]}.
    /// </returns>
    private static Dictionary<string, int[][]> LayerHinzuf�gen_LeerDokumenteErzeugen(Layer2 layer)
    {
      var docs = new Dictionary<string, int[][]>();

      foreach (var doc in layer)
      {
        var ins = new int[doc.Value.Length][];
        for (var i = 0; i < doc.Value.Length; i++)
          ins[i] = new int[doc.Value[i].Length];
        docs.Add(doc.Key, ins);
      }
      return docs;
    }

    /// <summary>
    ///   Layerwerts the �ndern call.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="layerWertAlt">The layer wert alt.</param>
    /// <param name="layerWertNeu">The layer wert neu.</param>
    /// <param name="korpus">The korpus.</param>
    /// <returns>
    ///   Layer.
    /// </returns>
    private static Layer2 Layerwert�ndernCall(string layerName, string layerWertAlt, string layerWertNeu,
      MultiLayer korpus)
    {
      var layer = korpus[layerName];
      var idx = layer._daten.IndexOf(layerWertAlt);
      if (idx == -1)
        return layer;

      layer._daten.RemoveAt(idx);
      layer._daten.Insert(idx, layerWertNeu);
      return layer;
    }

    /// <summary>
    ///   Layerwerts the hinzuf�gen call.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="layerWert">The layer wert.</param>
    /// <param name="korpus">The korpus.</param>
    /// <returns>
    ///   Layer.
    /// </returns>
    private static Layer2 LayerwertHinzuf�genCall(string layerName, string layerWert, MultiLayer korpus)
    {
      var layer = korpus[layerName];
      layer._daten.Add(layerWert);
      return layer;
    }

    /// <summary>
    ///   Layerwerts the l�schen call.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="layerWert">The layer wert.</param>
    /// <param name="korpus">The korpus.</param>
    /// <returns>
    ///   Layer.
    /// </returns>
    private static Layer2 LayerwertL�schenCall(string layerName, string layerWert, MultiLayer korpus)
    {
      var layer = korpus[layerName];

      var idx = layer._daten.IndexOf(layerWert);

      layer._daten.RemoveAt(idx);
      var empty = layer.IndexOf("");

      foreach (var satz in layer._dokumente.SelectMany(doc => doc.Value))
      {
        for (var j = 0; j < satz.Length; j++)
        {
          if (satz[j] == idx)
            satz[j] = empty;
          if (satz[j] > idx)
            satz[j] = satz[j] - 1;
        }
      }
      return layer;
    }

    /// <summary>
    ///   Dokumentens the <paramref name="wert" /> modifizieren call.
    /// </summary>
    /// <param name="layerName">Name of the layer.</param>
    /// <param name="dokumentName">Name of the dokument.</param>
    /// <param name="satzIndex">Index of the satz.</param>
    /// <param name="wortIndex">Index of the wort.</param>
    /// <param name="wert">The wert.</param>
    /// <param name="korpus">The korpus.</param>
    /// <returns>
    ///   Layer.
    /// </returns>
    private Layer2 DokumentenWertModifizierenCall(string layerName, string dokumentName, int satzIndex, int wortIndex,
      int wert, MultiLayer korpus)
    {
      var layer = korpus[layerName];
      layer[dokumentName][satzIndex][wortIndex] = layer[dokumentName][satzIndex][wortIndex] == wert ? 0 : wert;
      this[layerName][dokumentName][satzIndex][wortIndex] = this[layerName][dokumentName][satzIndex][wortIndex] == wert
        ? 0
        : wert;
      return layer;
    }

    /*
    /// <summary>
    ///   Z�hles the metaangaben.
    /// </summary>
    /// <param name="layer">The layer.</param>
    /// <param name="aAu">A au.</param>
    /// <param name="dMax">The d max.</param>
    /// <param name="dMin">The d min.</param>
    /// <param name="aPu">A pu.</param>
    /// <param name="aRu">A ru.</param>
    /// <param name="aZe">A ze.</param>
    /// <returns>
    ///   System.Int32.
    /// </returns>
    private int Z�hleMetaangaben(Layer layer, ref int aAu, ref DateTime dMax, ref DateTime dMin, ref int aPu,
                                 ref int aRu,
                                 ref int aZe)
    {
      var meta = _changes.SelectMany(entry => entry.Value.MetaDaten.Eintr�geDokumente)
                         .ToDictionary(x => x.Key, x => x.Value);

      var listA = new ListOptimized<string>();
      var listZ = new ListOptimized<string>();
      var listR = new ListOptimized<string>();
      var listP = new ListOptimized<string>();

      foreach (
        var eintrag in
          (from d in layer._dokumente.Select(x => x.Key) where meta.ContainsKey(d) select meta[d]).SelectMany(x => x))
      {
        switch (eintrag.Name)
        {
          case "Autor":
            if (!eintrag.IsNull && !listA.Contains((string) eintrag.InternValue))
              listA.Add((string) eintrag.InternValue);
            break;

          case "Datum":
            if (!eintrag.IsNull)
            {
              var dtv = (MetaEintragDatum) eintrag;
              if (dtv.Value > dMax)
                dMax = dtv.Value;
              if (dtv.Value < dMin)
                dMin = dtv.Value;
            }
            break;

          case "Publikation":
            if (!eintrag.IsNull && !listP.Contains((string) eintrag.InternValue))
              listP.Add((string) eintrag.InternValue);
            break;

          case "Rubrik":
            if (!eintrag.IsNull && !listR.Contains((string) eintrag.InternValue))
              listR.Add((string) eintrag.InternValue);
            break;

          case "Zeitung":
            if (!eintrag.IsNull && !listZ.Contains((string) eintrag.InternValue))
              listZ.Add((string) eintrag.InternValue);
            break;
        }
      }

      aAu = listA.Count;
      aPu = listP.Count;
      aZe = listZ.Count;
      aRu = listR.Count;
      return aAu;
    }

    */
  }
}
#region

using System;

#endregion

namespace CorpusExplorer.Sdk.Blocks.ReadingEase
{
  /// <summary>
  ///   The wiener sachtext v 2 index.
  /// </summary>
  [Serializable]
  public class WienerSachtextV2Index : AbstractReadingEaseIndex
  {
    public override string Displayname => "Wiener Sachtext Index (v2)";

    /// <summary>
    ///   The calculate index.
    /// </summary>
    /// <param name="averageSentenceLength">
    ///   The average sentence length.
    /// </param>
    /// <param name="averageNumberOfSyllablesPerWord">
    ///   The average number of syllables per word.
    /// </param>
    /// <param name="ms">
    ///   The ms.
    /// </param>
    /// <param name="iw">
    ///   The iw.
    /// </param>
    /// <param name="es">
    ///   The es.
    /// </param>
    /// <param name="hypenCount3More">
    ///   The hypen count 3 more.
    /// </param>
    /// <returns>
    ///   The <see cref="double" />.
    /// </returns>
    public override double CalculateIndex(
      double averageSentenceLength,
      double averageNumberOfSyllablesPerWord,
      double ms,
      double iw,
      double es,
      double hypenCount3More)
    {
      return 0.2007 * ms + 0.1682 * averageSentenceLength + 0.1373 * iw - 0.875;
    }
  }
}
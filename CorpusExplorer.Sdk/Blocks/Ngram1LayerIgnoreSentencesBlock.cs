﻿#region

using System;
using System.Collections.Generic;
using System.Linq;
using CorpusExplorer.Sdk.Blocks.Abstract;
using CorpusExplorer.Sdk.Ecosystem.Model;
using CorpusExplorer.Sdk.Helper;
using CorpusExplorer.Sdk.Model.Adapter.Corpus.Abstract;
using CorpusExplorer.Sdk.Model.Adapter.Layer.Abstract;

#endregion

namespace CorpusExplorer.Sdk.Blocks
{
  [Serializable]
  public class Ngram1LayerIgnoreSentencesBlock : AbstractSimple1LayerBlock
  {
    private readonly object _lock = new object();

    public Dictionary<string, int> NGramFrequency { get; private set; }

    public int NGramSize { get; set; } = 3;

    protected override void CalculateCall(
      AbstractCorpusAdapter corpus,
      AbstractLayerAdapter layer,
      Guid dsel,
      int[][] doc)
    {
      var dic = new Dictionary<string, int>();
      var stream = layer.ConvertToReadableDocument(doc).ReduceDocumentToStreamDocument().ToArray();
      var ngram = new string[NGramSize];

      var max = stream.Length - NGramSize + 1;
        for (var i = 0; i < max; i++)
        {
          for (var j = 0; j < NGramSize; j++)
            ngram[j] = stream[i + j]?.Replace(" ", string.Empty);

          var key = string.Join(" ", ngram);
          if (dic.ContainsKey(key))
            dic[key]++;
          else
            dic.Add(key, 1);
        }

      lock (_lock)
        foreach (var x in dic)
          if (NGramFrequency.ContainsKey(x.Key))
            NGramFrequency[x.Key] += x.Value;
          else
            NGramFrequency.Add(x.Key, x.Value);
    }

    protected override void CalculateCleanup()
    {
    }

    protected override void CalculateFinalize()
    {
    }

    protected override void CalculateInitProperties()
    {
      NGramFrequency = new Dictionary<string, int>();

      // Property FIX!

      if (NGramSize < 1)
        NGramSize = 1;

      if (NGramSize > 99)
        NGramSize = 99;
    }
  }
}
﻿using System.Collections.Generic;
using System.Data;
using CorpusExplorer.Sdk.Blocks;
using CorpusExplorer.Sdk.Properties;
using CorpusExplorer.Sdk.ViewModel.Abstract;
using CorpusExplorer.Sdk.ViewModel.Interfaces;

namespace CorpusExplorer.Sdk.ViewModel
{
  public class Frequency3LayerViewModel : AbstractViewModel, IProvideDataTable
  {
    private Frequency3LayerBlock _block;

    public Dictionary<string, Dictionary<string, Dictionary<string, double>>> Frequency { get; set; }

    public string Layer1Displayname { get; set; } = "POS";

    public string Layer2Displayname { get; set; } = "Lemma";

    public string Layer3Displayname { get; set; } = "Wort";

    /// <summary>
    ///   Gets the data table.
    /// </summary>
    public DataTable GetDataTable()
    {
      var res = new DataTable();

      res.Columns.Add(Layer1Displayname, typeof(string));
      res.Columns.Add(Layer2Displayname, typeof(string));
      res.Columns.Add(Layer3Displayname, typeof(string));
      res.Columns.Add(Resources.Frequency, typeof(double));

      res.BeginLoadData();

      foreach (var f in Frequency)
      foreach (var s in f.Value)
      foreach (var t in s.Value)
        res.Rows.Add(f.Key, s.Key, t.Key, t.Value);

      res.EndLoadData();
      return res;
    }

    protected override void ExecuteAnalyse()
    {
      _block = Selection.CreateBlock<Frequency3LayerBlock>();
      _block.Layer1Displayname = Layer1Displayname;
      _block.Layer2Displayname = Layer2Displayname;
      _block.Layer3Displayname = Layer3Displayname;

      _block.Calculate();
      Frequency = _block.Frequency;
    }

    protected override bool Validate() { return true; }
  }
}
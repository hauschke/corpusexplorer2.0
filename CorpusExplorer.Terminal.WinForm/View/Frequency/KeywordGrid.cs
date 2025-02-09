﻿#region

using System;
using System.Data;
using System.Windows.Forms;
using CorpusExplorer.Sdk.ViewModel;
using CorpusExplorer.Terminal.WinForm.Controls.WinForm;
using CorpusExplorer.Terminal.WinForm.Forms.SelectLayer;
using CorpusExplorer.Terminal.WinForm.Forms.Splash;
using CorpusExplorer.Terminal.WinForm.Helper.UiFramework;
using CorpusExplorer.Terminal.WinForm.Properties;
using CorpusExplorer.Terminal.WinForm.View.AbstractTemplates;
using Telerik.WinControls.UI;

#endregion

namespace CorpusExplorer.Terminal.WinForm.View.Frequency
{
  /// <summary>
  ///   The grid visualisation.
  /// </summary>
  public partial class KeywordGrid : AbstractGridView
  {
    private readonly SnapshotDropdown _selectionDropdown1 = new SnapshotDropdown();
    private DataTable _table;
    private KeywordViewModel _vm;

    /// <summary>
    ///   Initializes a new instance of the <see cref="AbstractView" /> class.
    /// </summary>
    public KeywordGrid()
    {
      InitializeComponent();
      commandBarHostItem1.Padding = new Padding(0, 3, 0, 0);
      commandBarHostItem1.HostedControl = _selectionDropdown1;

      InitializeGrid(radGridView1);
      ShowView += ShowViewCall;
    }

    /// <summary>
    ///   The btn_calc_ click.
    /// </summary>
    /// <param name="sender">
    ///   The sender.
    /// </param>
    /// <param name="e">
    ///   The e.
    /// </param>
    private void btn_calc_Click(object sender, EventArgs e)
    {
      CalculatorFunction();
    }

    /// <summary>
    ///   The btn_csv export_ click.
    /// </summary>
    /// <param name="sender">
    ///   The sender.
    /// </param>
    /// <param name="e">
    ///   The e.
    /// </param>
    private void btn_csvExport_Click(object sender, EventArgs e)
    {
      ExportFunction();
    }

    private void btn_filtereditor_Click(object sender, EventArgs e)
    {
      QueryBuilderFunction(Resources.Keywordanalitics);
    }

    private void btn_filterlist_Click(object sender, EventArgs e)
    {
      FilterListFunction(Resources.StringLabelLong);
    }

    private void btn_ok_Click(object sender, EventArgs e)
    {
      Analyse();
    }

    private void Analyse()
    {
      if (_selectionDropdown1.ResultSelection == null)
        return;

      Processing.Invoke(
                        Resources.VergleicheSchnappschüsse,
                        () =>
                        {
                          _vm.Selection = Project.CurrentSelection;
                          _vm.SelectionToCompare = _selectionDropdown1.ResultSelection;
                          if (SelectedLayerDisplaynames != null)
                            _vm.LayerDisplayname = SelectedLayerDisplaynames[0];
                          if (!_vm.Execute())
                            return;

                          _table = _vm.GetDataTable();

                          radGridView1.DataSource = _table;
                          radGridView1.ResetBindings();
                          radGridView1.BestFitColumns(BestFitColumnMode.HeaderCells);
                          radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                          ApplyFilterDelay();
                        });
    }

    /// <summary>
    ///   The btn_print_ click.
    /// </summary>
    /// <param name="sender">
    ///   The sender.
    /// </param>
    /// <param name="e">
    ///   The e.
    /// </param>
    private void btn_print_Click(object sender, EventArgs e)
    {
      radGridView1.PrintPreview();
    }

    private void ShowViewCall(object sender, EventArgs e)
    {
      _vm = GetViewModel<KeywordViewModel>();
      _selectionDropdown1.RefreshSelectionTree();
    }

    private void btn_layer_Click(object sender, EventArgs e)
    {
      var form = new Select1Layer(SelectedLayerDisplaynames);
      form.ShowDialog();
      SelectedLayerDisplaynames = form.ResultSelectedLayerDisplaynames;
      Analyse();
    }

    private void btn_regex_Click(object sender, EventArgs e)
    {
      RegexFunction();
    }

    private void btn_posFilter_Click(object sender, EventArgs e)
    {
      var form = new PosFilter(Project.CurrentSelection, _vm.LayerDisplayname) { ShowAllOption = false };
      form.ShowDialog();

      _vm.CorrespondingLayerValueFilter = form.Result;
      radGridView1.DataSource = _vm.GetDataTable();
      radGridView1.ResetBindings();
    }
  }
}
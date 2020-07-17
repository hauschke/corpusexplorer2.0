using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Utils.Filter.Abstract;
using CorpusExplorer.Sdk.ViewModel;
using CorpusExplorer.Terminal.WinForm.Forms.Simple;
using CorpusExplorer.Terminal.WinForm.Forms.Splash;
using CorpusExplorer.Terminal.WinForm.Properties;
using Telerik.WinControls.UI;

namespace CorpusExplorer.Terminal.WinForm.View.AbstractTemplates
{
  public partial class AbstractGridViewWithTextLense : AbstractGridView
  {
    private GridViewTemplate _childTemplate;
    private GetFilterQueryDelegate _func;
    private DateTime _preventDoubleCommandClick = DateTime.Now;

    public AbstractGridViewWithTextLense()
    {
      InitializeComponent();
      UseParentCellForHighlighting = null;
    }

    protected string UseParentCellForHighlighting { get; set; }

    protected void AddChildTemplate(GetFilterQueryDelegate func)
    {
      if (_grid == null)
        throw GridException;

      _func = func;

      _grid.Templates.Clear();
      _childTemplate = CreateChildTemplate();
      _grid.Templates.Add(_childTemplate);
      _childTemplate.HierarchyDataProvider = new GridViewEventDataProvider(_childTemplate);

      _grid.RowSourceNeeded -= radGridView1_RowSourceNeeded;
      _grid.RowSourceNeeded += radGridView1_RowSourceNeeded;
    }

    private GridViewTemplate CreateChildTemplate()
    {
      if (_grid == null)
        throw GridException;

      var template = new GridViewTemplate
      {
        AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill,
        AllowAddNewRow = false,
        AllowDeleteRow = false,
        AllowEditRow = false,
        EnableGrouping = true,
        EnableFiltering = true
        //EnableSorting = true, HorizontalScrollState = ScrollState.AlwaysShow
      };

      var txtpre = new GridViewTextBoxColumn(Resources.Links)
      {
        TextAlignment = ContentAlignment.MiddleRight,
        AutoSizeMode = BestFitColumnMode.AllCells
      };
      var txtcontent = new GridViewTextBoxColumn(Resources.Fundstelle)
      {
        TextAlignment = ContentAlignment.MiddleCenter,
        AutoSizeMode = BestFitColumnMode.AllCells
      };
      var txtpost = new GridViewTextBoxColumn(Resources.Rechts)
      {
        TextAlignment = ContentAlignment.MiddleLeft,
        AutoSizeMode = BestFitColumnMode.AllCells
      };
      var txtbtn = new GridViewCommandColumn(Resources.Details)
      {
        AllowFiltering = false,
        AllowGroup = false,
        HeaderText = "",
        DefaultText = "",
        UseDefaultText = true,
        MaxWidth = 37,
        Image = Resources.find
      };
      var txtindex =
        new GridViewTextBoxColumn("Info") {IsVisible = false, DataType = typeof(IEnumerable<KeyValuePair<Guid, int>>)};

      template.Columns.AddRange(
                                txtpre,
                                txtcontent,
                                txtpost,
                                new GridViewTextBoxColumn(Resources.Frequency)
                                {
                                  DataType = typeof(int),
                                  MaxWidth = 85,
                                  TextAlignment = ContentAlignment.MiddleCenter
                                },
                                txtbtn,
                                txtindex);

      template.SortDescriptors.Add(Resources.Frequency, ListSortDirection.Descending);
      _grid.CommandCellClick += OnGridOnCommandCellClick;

      return template;
    }

    private void OnGridOnCommandCellClick(object sender, GridViewCellEventArgs arg)
    {
      if ((DateTime.Now - _preventDoubleCommandClick).Seconds < 1)
        return;

      if (!(sender is GridCommandCellElement cell))
        return;

      Processing.SplashShow("Suche passende Belege...");
      var vm = GetViewModel<QuickInfoTextViewModel>();
      vm.Documents = cell.RowElement.RowInfo.Cells["Info"].Value as IEnumerable<KeyValuePair<Guid, int>>;
      vm.Execute();

      var form = new SimpleTextView(vm.QuickDocumentInfoResults, Project);
      form.NewProperty += (o, a) => { vm.SetNewDocumentMetadata((KeyValuePair<string, Type>) o); };
      Processing.SplashClose();

      if (form.ShowDialog() == DialogResult.OK)
        foreach (var doc in form.Documents)
          Project.CurrentSelection.SetDocumentMetadata(doc.DocumentGuid, doc.DocumentMetadata);

      _preventDoubleCommandClick = DateTime.Now;
    }

    private void radGridView1_RowSourceNeeded(object sender, GridViewRowSourceNeededEventArgs e)
    {
      var parent = e.ParentRow.DataBoundItem as DataRowView;
      if (parent == null)
        return;

      var vm = GetViewModel<TextLiveSearchViewModel>();
      vm.ClearQueries();
      vm.AddQuery(_func(parent));
      vm.Execute();

      var dt = vm.GetUniqueData();
      foreach (var row in dt)
      {
        var r = e.Template.Rows.NewRow();
        r.Cells[Resources.Links].Value = row.Pre;
        r.Cells[Resources.Fundstelle].Value = row.Match;
        r.Cells[Resources.Rechts].Value = row.Post;
        r.Cells[Resources.Frequency].Value = row.Count;
        r.Cells["Info"].Value = row.Sentences;
        e.SourceCollection.Add(r);
      }
    }

    protected delegate AbstractFilterQuery GetFilterQueryDelegate(DataRowView row);

    protected delegate IEnumerable<KeyValuePair<Guid, int>> GetKwicResultDelegate(DataRowView row);
  }
}
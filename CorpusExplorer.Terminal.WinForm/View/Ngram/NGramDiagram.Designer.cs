using CorpusExplorer.Terminal.WinForm.Properties;
namespace CorpusExplorer.Terminal.WinForm.View.Ngram
{
  partial class NGramDiagram
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
      this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
      this.commandBarStripElement3 = new Telerik.WinControls.UI.CommandBarStripElement();
      this.commandBarLabel4 = new Telerik.WinControls.UI.CommandBarLabel();
      this.combo_layer = new Telerik.WinControls.UI.CommandBarDropDownList();
      this.commandBarLabel2 = new Telerik.WinControls.UI.CommandBarLabel();
      this.txt_size = new Telerik.WinControls.UI.CommandBarTextBox();
      this.commandBarLabel3 = new Telerik.WinControls.UI.CommandBarLabel();
      this.txt_pattern = new Telerik.WinControls.UI.CommandBarTextBox();
      this.commandBarLabel1 = new Telerik.WinControls.UI.CommandBarLabel();
      this.txt_max = new Telerik.WinControls.UI.CommandBarTextBox();
      this.commandBarDropDownButton2 = new Telerik.WinControls.UI.CommandBarDropDownButton();
      this.btn_analyse_simple = new Telerik.WinControls.UI.RadMenuItem();
      this.btn_analyse_aggregated = new Telerik.WinControls.UI.RadMenuItem();
      this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
      this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
      this.commandBarDropDownButton1 = new Telerik.WinControls.UI.CommandBarDropDownButton();
      this.btn_layout_default = new Telerik.WinControls.UI.RadMenuItem();
      this.btn_layout_tree = new Telerik.WinControls.UI.RadMenuItem();
      this.btn_save = new Telerik.WinControls.UI.CommandBarButton();
      this.commandBarDropDownButton3 = new Telerik.WinControls.UI.CommandBarDropDownButton();
      this.btn_export_graphviz = new Telerik.WinControls.UI.RadMenuItem();
      this.btn_export_gexf = new Telerik.WinControls.UI.RadMenuItem();
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.simpleDiagram1 = new CorpusExplorer.Terminal.WinForm.Controls.Wpf.Diagram.WpfDiagram();
      ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // radCommandBar1
      // 
      this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
      this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
      this.radCommandBar1.Name = "radCommandBar1";
      this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement2,
            this.commandBarRowElement1});
      this.radCommandBar1.Size = new System.Drawing.Size(780, 110);
      this.radCommandBar1.TabIndex = 0;
      this.radCommandBar1.Text = "radCommandBar1";
      // 
      // commandBarRowElement2
      // 
      this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
      this.commandBarRowElement2.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement3});
      // 
      // commandBarStripElement3
      // 
      this.commandBarStripElement3.DisplayName = "commandBarStripElement3";
      this.commandBarStripElement3.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarLabel4,
            this.combo_layer,
            this.commandBarLabel2,
            this.txt_size,
            this.commandBarLabel3,
            this.txt_pattern,
            this.commandBarLabel1,
            this.txt_max,
            this.commandBarDropDownButton2});
      this.commandBarStripElement3.Name = "commandBarStripElement3";
      // 
      // commandBarLabel4
      // 
      this.commandBarLabel4.DisplayName = "commandBarLabel4";
      this.commandBarLabel4.Name = "commandBarLabel4";
      this.commandBarLabel4.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.LayerDP;
      // 
      // combo_layer
      // 
      this.combo_layer.DisplayName = "commandBarDropDownList1";
      this.combo_layer.DropDownAnimationEnabled = true;
      this.combo_layer.MaxDropDownItems = 0;
      this.combo_layer.MinSize = new System.Drawing.Size(200, 22);
      this.combo_layer.Name = "combo_layer";
      this.combo_layer.NullText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.BitteLayerWählen;
      this.combo_layer.Text = "";
      // 
      // commandBarLabel2
      // 
      this.commandBarLabel2.DisplayName = "commandBarLabel2";
      this.commandBarLabel2.Name = "commandBarLabel2";
      this.commandBarLabel2.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.NGramGröße;
      // 
      // txt_size
      // 
      this.txt_size.AccessibleDescription = "3";
      this.txt_size.AccessibleName = "3";
      this.txt_size.DisplayName = "commandBarTextBox1";
      this.txt_size.Name = "txt_size";
      this.txt_size.Text = "5";
      // 
      // commandBarLabel3
      // 
      this.commandBarLabel3.DisplayName = "commandBarLabel3";
      this.commandBarLabel3.Name = "commandBarLabel3";
      this.commandBarLabel3.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.Musteranzahl;
      // 
      // txt_pattern
      // 
      this.txt_pattern.DisplayName = "commandBarTextBox2";
      this.txt_pattern.Name = "txt_pattern";
      this.txt_pattern.Text = "0";
      // 
      // commandBarLabel1
      // 
      this.commandBarLabel1.DisplayName = "commandBarLabel1";
      this.commandBarLabel1.Name = "commandBarLabel1";
      this.commandBarLabel1.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.Top;
      // 
      // txt_max
      // 
      this.txt_max.DisplayName = "commandBarTextBox1";
      this.txt_max.Name = "txt_max";
      this.txt_max.Text = "100";
      // 
      // commandBarDropDownButton2
      // 
      this.commandBarDropDownButton2.AccessibleDescription = "commandBarDropDownButton2";
      this.commandBarDropDownButton2.AccessibleName = "commandBarDropDownButton2";
      this.commandBarDropDownButton2.DisplayName = "commandBarDropDownButton2";
      this.commandBarDropDownButton2.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.button_circle_right;
      this.commandBarDropDownButton2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btn_analyse_simple,
            this.btn_analyse_aggregated});
      this.commandBarDropDownButton2.Name = "commandBarDropDownButton2";
      this.commandBarDropDownButton2.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.AnalyseAusführen;
      this.commandBarDropDownButton2.ToolTipText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.AnalyseAusführen;
      // 
      // btn_analyse_simple
      // 
      this.btn_analyse_simple.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.button_circle_right;
      this.btn_analyse_simple.Name = "btn_analyse_simple";
      this.btn_analyse_simple.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.EinfacheAnalyse;
      this.btn_analyse_simple.Click += new System.EventHandler(this.btn_execute_Click);
      // 
      // btn_analyse_aggregated
      // 
      this.btn_analyse_aggregated.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.button_circle_right;
      this.btn_analyse_aggregated.Name = "btn_analyse_aggregated";
      this.btn_analyse_aggregated.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.AggregierteAnalyse;
      this.btn_analyse_aggregated.Click += new System.EventHandler(this.btn_analyse_aggregated_Click);
      // 
      // commandBarRowElement1
      // 
      this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
      this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
      // 
      // commandBarStripElement1
      // 
      this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
      this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarDropDownButton1,
            this.btn_save,
            this.commandBarDropDownButton3});
      this.commandBarStripElement1.Name = "commandBarStripElement1";
      // 
      // commandBarDropDownButton1
      // 
      this.commandBarDropDownButton1.DisplayName = "commandBarDropDownButton1";
      this.commandBarDropDownButton1.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.diagram1;
      this.commandBarDropDownButton1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btn_layout_default,
            this.btn_layout_tree});
      this.commandBarDropDownButton1.Name = "commandBarDropDownButton1";
      this.commandBarDropDownButton1.Text = "commandBarDropDownButton1";
      this.commandBarDropDownButton1.ToolTipText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.DiagrammLayouten;
      // 
      // btn_layout_default
      // 
      this.btn_layout_default.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.diagram1;
      this.btn_layout_default.Name = "btn_layout_default";
      this.btn_layout_default.Text = "Netzwerk-Layout";
      this.btn_layout_default.Click += new System.EventHandler(this.btn_layout_network_Click);
      // 
      // btn_layout_tree
      // 
      this.btn_layout_tree.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.diagram1;
      this.btn_layout_tree.Name = "btn_layout_tree";
      this.btn_layout_tree.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.BaumLayout;
      this.btn_layout_tree.Click += new System.EventHandler(this.btn_layout_tree_Click);
      // 
      // btn_save
      // 
      this.btn_save.DisplayName = "commandBarButton1";
      this.btn_save.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.save;
      this.btn_save.Name = "btn_save";
      this.btn_save.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.Speichern;
      this.btn_save.ToolTipText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.DiagrammSpeichern;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      // 
      // commandBarDropDownButton3
      // 
      this.commandBarDropDownButton3.DisplayName = "commandBarDropDownButton3";
      this.commandBarDropDownButton3.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.save_theme;
      this.commandBarDropDownButton3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btn_export_graphviz,
            this.btn_export_gexf});
      this.commandBarDropDownButton3.Name = "commandBarDropDownButton3";
      this.commandBarDropDownButton3.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.Export;
      this.commandBarDropDownButton3.ToolTipText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.DiagrammExportieren;
      // 
      // btn_export_graphviz
      // 
      this.btn_export_graphviz.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.save_theme;
      this.btn_export_graphviz.Name = "btn_export_graphviz";
      this.btn_export_graphviz.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.AlsGraphVizExportieren;
      this.btn_export_graphviz.Click += new System.EventHandler(this.btn_export_graphviz_Click);
      // 
      // btn_export_gexf
      // 
      this.btn_export_gexf.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.save_theme;
      this.btn_export_gexf.Name = "btn_export_gexf";
      this.btn_export_gexf.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.AlsGEXFXMLExportieren;
      this.btn_export_gexf.Click += new System.EventHandler(this.btn_export_gexf_Click);
      // 
      // elementHost1
      // 
      this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.elementHost1.Location = new System.Drawing.Point(0, 110);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(780, 290);
      this.elementHost1.TabIndex = 1;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = this.simpleDiagram1;
      // 
      // NGramDiagram
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.elementHost1);
      this.Controls.Add(this.radCommandBar1);
      this.Name = "NGramDiagram";
      ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
    private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
    private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement3;
    private Telerik.WinControls.UI.CommandBarLabel commandBarLabel2;
    private Telerik.WinControls.UI.CommandBarTextBox txt_size;
    private Telerik.WinControls.UI.CommandBarLabel commandBarLabel3;
    private Telerik.WinControls.UI.CommandBarTextBox txt_pattern;
    private Telerik.WinControls.UI.CommandBarDropDownButton commandBarDropDownButton1;
    private Telerik.WinControls.UI.RadMenuItem btn_layout_tree;
    private Telerik.WinControls.UI.RadMenuItem btn_layout_default;
    private Telerik.WinControls.UI.CommandBarDropDownButton commandBarDropDownButton2;
    private Telerik.WinControls.UI.RadMenuItem btn_analyse_simple;
    private Telerik.WinControls.UI.RadMenuItem btn_analyse_aggregated;
    private Telerik.WinControls.UI.CommandBarLabel commandBarLabel1;
    private Telerik.WinControls.UI.CommandBarTextBox txt_max;
    private Telerik.WinControls.UI.CommandBarButton btn_save;
    private Telerik.WinControls.UI.CommandBarDropDownButton commandBarDropDownButton3;
    private Telerik.WinControls.UI.RadMenuItem btn_export_graphviz;
    private Telerik.WinControls.UI.RadMenuItem btn_export_gexf;
    private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
    private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
    private Telerik.WinControls.UI.CommandBarLabel commandBarLabel4;
    private Telerik.WinControls.UI.CommandBarDropDownList combo_layer;
    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private Controls.Wpf.Diagram.WpfDiagram simpleDiagram1;
  }
}

﻿using CorpusExplorer.Terminal.WinForm.Controls.WinForm;
using CorpusExplorer.Terminal.WinForm.Controls.WinForm.Webbrowser;

namespace CorpusExplorer.Terminal.WinForm.View.Cooccurrence
{
  partial class CooccurrenceTagPie
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
      if (disposing && (components != null))
      {
        components.Dispose();
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CooccurrenceTagPie));
      this.wordBag1 = new CorpusExplorer.Terminal.WinForm.Controls.WinForm.WordBag();
      this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
      this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
      this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
      this.commandBarButton4 = new Telerik.WinControls.UI.CommandBarButton();
      this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
      this.webHtml5Visualisation1 = new CorpusExplorer.Terminal.WinForm.Controls.WinForm.Webbrowser.WebHtml5Visualisation();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // wordBag1
      // 
      this.wordBag1.BackColor = System.Drawing.Color.White;
      this.wordBag1.Dock = System.Windows.Forms.DockStyle.Top;
      this.wordBag1.Font = new System.Drawing.Font("Segoe UI", 11F);
      this.wordBag1.Location = new System.Drawing.Point(0, 0);
      this.wordBag1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.wordBag1.MinimumSize = new System.Drawing.Size(413, 65);
      this.wordBag1.Name = "wordBag1";
      this.wordBag1.Queries = new string[0];
      this.wordBag1.Selection = null;
      this.wordBag1.Size = new System.Drawing.Size(780, 80);
      this.wordBag1.TabIndex = 0;
      this.wordBag1.ExecuteButtonClicked += new System.EventHandler(this.wordBag1_ExecuteButtonClicked);
      this.wordBag1.Load += new System.EventHandler(this.wordBag1_Load);
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
            this.commandBarButton1,
            this.commandBarButton4,
            this.commandBarButton3});
      this.commandBarStripElement1.Name = "commandBarStripElement1";
      // 
      // commandBarButton1
      // 
      this.commandBarButton1.DisplayName = "commandBarButton1";
      this.commandBarButton1.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.print;
      this.commandBarButton1.Name = "commandBarButton1";
      this.commandBarButton1.Text = "Drucken";
      this.commandBarButton1.Click += new System.EventHandler(this.commandBarButton1_Click);
      // 
      // commandBarButton4
      // 
      this.commandBarButton4.DisplayName = "commandBarButton4";
      this.commandBarButton4.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.export_pdf;
      this.commandBarButton4.Name = "commandBarButton4";
      this.commandBarButton4.Text = "PDF-Export";
      this.commandBarButton4.Click += new System.EventHandler(this.commandBarButton4_Click);
      // 
      // commandBarButton3
      // 
      this.commandBarButton3.DisplayName = "commandBarButton3";
      this.commandBarButton3.Image = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.image_save;
      this.commandBarButton3.Name = "commandBarButton3";
      this.commandBarButton3.Text = "Bild-Export";
      this.commandBarButton3.Click += new System.EventHandler(this.commandBarButton3_Click);
      // 
      // webHtml5Visualisation1
      // 
      this.webHtml5Visualisation1.BackColor = System.Drawing.Color.White;
      this.webHtml5Visualisation1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webHtml5Visualisation1.Location = new System.Drawing.Point(0, 80);
      this.webHtml5Visualisation1.MainpageUrl = null;
      this.webHtml5Visualisation1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.webHtml5Visualisation1.Name = "webHtml5Visualisation1";
      this.webHtml5Visualisation1.Size = new System.Drawing.Size(780, 320);
      this.webHtml5Visualisation1.TabIndex = 3;
      this.webHtml5Visualisation1.TemplateVars = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("webHtml5Visualisation1.TemplateVars")));
      // 
      // timer1
      // 
      this.timer1.Interval = 5000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // CooccurrenceTagPie
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.webHtml5Visualisation1);
      this.Controls.Add(this.wordBag1);
      this.Name = "CooccurrenceTagPie";
      this.ShowView += new System.EventHandler(this.WordCloudVisualisation_ShowVisualisation);
      this.ResumeLayout(false);

    }

    #endregion

    private WordBag wordBag1;
    private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
    private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
    private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
    private Telerik.WinControls.UI.CommandBarButton commandBarButton4;
    private WebHtml5Visualisation webHtml5Visualisation1;
    private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
    private System.Windows.Forms.Timer timer1;
  }
}

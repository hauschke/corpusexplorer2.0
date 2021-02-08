﻿namespace CorpusExplorer.Terminal.WinForm.Forms.Tagger
{
  partial class AdditionalTagger
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalTagger));
      this._headPanel1 = new CorpusExplorer.Terminal.WinForm.Controls.WinForm.HeadPanel();
      this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
      this.combo_tagger = new Telerik.WinControls.UI.RadDropDownList();
      this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
      this.lbl_destination = new System.Windows.Forms.Label();
      this.btn_destination = new Telerik.WinControls.UI.RadButton();
      this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
      this.radGroupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.combo_tagger)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
      this.radGroupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.btn_destination)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radPanel1
      // 
      resources.ApplyResources(this.radPanel1, "radPanel1");
      // 
      // _headPanel1
      // 
      this._headPanel1.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this._headPanel1, "_headPanel1");
      this._headPanel1.HeadPanelDescription = "Wählen Sie einen Tagger und konfigurieren Sie ihn für die automatische Annotation" +
    ".";
      this._headPanel1.HeadPanelTitle = "Tagger-Optionen";
      this._headPanel1.HeadPanelImage = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.tag_green1;
      this._headPanel1.Name = "_headPanel1";
      // 
      // radGroupBox1
      // 
      this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add(this.combo_tagger);
      resources.ApplyResources(this.radGroupBox1, "radGroupBox1");
      this.radGroupBox1.HeaderText = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.VerfügbareTaggerKonfigurationen;
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Text = global::CorpusExplorer.Terminal.WinForm.Properties.Resources.VerfügbareTaggerKonfigurationen;
      // 
      // combo_tagger
      // 
      resources.ApplyResources(this.combo_tagger, "combo_tagger");
      this.combo_tagger.Name = "combo_tagger";
      // 
      // radGroupBox3
      // 
      this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox3.Controls.Add(this.lbl_destination);
      this.radGroupBox3.Controls.Add(this.btn_destination);
      resources.ApplyResources(this.radGroupBox3, "radGroupBox3");
      this.radGroupBox3.Name = "radGroupBox3";
      // 
      // lbl_destination
      // 
      resources.ApplyResources(this.lbl_destination, "lbl_destination");
      this.lbl_destination.Name = "lbl_destination";
      // 
      // btn_destination
      // 
      resources.ApplyResources(this.btn_destination, "btn_destination");
      this.btn_destination.Name = "btn_destination";
      this.btn_destination.Click += new System.EventHandler(this.btn_destination_Click);
      // 
      // radLabel1
      // 
      resources.ApplyResources(this.radLabel1, "radLabel1");
      this.radLabel1.Name = "radLabel1";
      // 
      // AdditionalTagger
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.radLabel1);
      this.Controls.Add(this.radGroupBox3);
      this.Controls.Add(this.radGroupBox1);
      this.Controls.Add(this._headPanel1);
      this.DisplayAbort = true;
      this.Name = "AdditionalTagger";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.Controls.SetChildIndex(this.radPanel1, 0);
      this.Controls.SetChildIndex(this._headPanel1, 0);
      this.Controls.SetChildIndex(this.radGroupBox1, 0);
      this.Controls.SetChildIndex(this.radGroupBox3, 0);
      this.Controls.SetChildIndex(this.radLabel1, 0);
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.combo_tagger)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
      this.radGroupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.btn_destination)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.WinForm.HeadPanel _headPanel1;
    private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    private Telerik.WinControls.UI.RadDropDownList combo_tagger;
    private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
    private System.Windows.Forms.Label lbl_destination;
    private Telerik.WinControls.UI.RadButton btn_destination;
    private Telerik.WinControls.UI.RadLabel radLabel1;
  }
}
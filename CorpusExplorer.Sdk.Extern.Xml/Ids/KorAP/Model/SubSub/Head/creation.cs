﻿namespace CorpusExplorer.Sdk.Extern.Xml.Ids.KorAP.Model.SubSub.Head
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class creation
  {

    private string creatDateField;

    private string creatRefField;

    private string creatRefShortField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "NMTOKEN")]
    public string creatDate
    {
      get { return this.creatDateField; }
      set { this.creatDateField = value; }
    }

    /// <remarks/>
    public string creatRef
    {
      get { return this.creatRefField; }
      set { this.creatRefField = value; }
    }

    /// <remarks/>
    public string creatRefShort
    {
      get { return this.creatRefShortField; }
      set { this.creatRefShortField = value; }
    }
  }
}
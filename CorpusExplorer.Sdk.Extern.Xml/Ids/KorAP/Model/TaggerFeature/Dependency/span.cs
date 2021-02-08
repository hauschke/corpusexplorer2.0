﻿namespace CorpusExplorer.Sdk.Extern.Xml.Ids.KorAP.Model.TaggerFeature.Dependency
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ids-mannheim.de/ns/KorAP")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ids-mannheim.de/ns/KorAP", IsNullable = false)]
  public partial class span
  {

    private rel relField;

    private string fromField;

    private string idField;

    private string toField;

    /// <remarks/>
    public rel rel
    {
      get { return this.relField; }
      set { this.relField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string from
    {
      get { return this.fromField; }
      set { this.fromField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NCName")]
    public string id
    {
      get { return this.idField; }
      set { this.idField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string to
    {
      get { return this.toField; }
      set { this.toField = value; }
    }
  }
}
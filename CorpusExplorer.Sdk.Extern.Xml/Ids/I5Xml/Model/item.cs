﻿namespace CorpusExplorer.Sdk.Extern.Xml.Ids.I5Xml.Model
{
  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
  public partial class item
  {

    private object[] itemsField;

    private string[] textField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("autoSignature", typeof(autoSignature))]
    [System.Xml.Serialization.XmlElementAttribute("gap", typeof(gap))]
    [System.Xml.Serialization.XmlElementAttribute("hi", typeof(hi))]
    [System.Xml.Serialization.XmlElementAttribute("lb", typeof(lb))]
    [System.Xml.Serialization.XmlElementAttribute("list", typeof(list))]
    [System.Xml.Serialization.XmlElementAttribute("num", typeof(num))]
    [System.Xml.Serialization.XmlElementAttribute("orig", typeof(orig))]
    [System.Xml.Serialization.XmlElementAttribute("p", typeof(p))]
    [System.Xml.Serialization.XmlElementAttribute("pb", typeof(pb))]
    [System.Xml.Serialization.XmlElementAttribute("ptr", typeof(ptr))]
    [System.Xml.Serialization.XmlElementAttribute("q", typeof(q))]
    [System.Xml.Serialization.XmlElementAttribute("ref", typeof(@ref))]
    [System.Xml.Serialization.XmlElementAttribute("s", typeof(s))]
    [System.Xml.Serialization.XmlElementAttribute("title", typeof(title))]
    [System.Xml.Serialization.XmlElementAttribute("xptr", typeof(xptr))]
    public object[] Items
    {
      get { return this.itemsField; }
      set { this.itemsField = value; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
      get { return this.textField; }
      set { this.textField = value; }
    }
  }
}
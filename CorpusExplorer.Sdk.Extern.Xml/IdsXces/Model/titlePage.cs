using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.IdsXces.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.6.81.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class titlePage
  {
    private byline bylineField;

    private string[] docImprintField;

    private titlePart[] docTitleField;

    private string idField;

    private object itemField;

    /// <remarks />
    public byline byline { get { return bylineField; } set { bylineField = value; } }

    /// <remarks />
    [XmlElement("docImprint")]
    public string[] docImprint { get { return docImprintField; } set { docImprintField = value; } }

    /// <remarks />
    [XmlArrayItem("titlePart", IsNullable = false)]
    public titlePart[] docTitle { get { return docTitleField; } set { docTitleField = value; } }

    /// <remarks />
    [XmlAttribute(DataType = "NCName")]
    public string id { get { return idField; } set { idField = value; } }

    /// <remarks />
    [XmlElement("docEdition", typeof(string))]
    [XmlElement("epigraph", typeof(epigraph))]
    public object Item { get { return itemField; } set { itemField = value; } }
  }
}
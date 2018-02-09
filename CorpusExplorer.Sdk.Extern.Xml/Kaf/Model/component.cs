using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.Kaf.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.6.1055.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class component
  {
    private string caseField;

    private externalRef[][] externalReferencesField;

    private string idField;

    private string lemmaField;

    private string posField;

    /// <remarks />
    [XmlAttribute]
    public string @case { get { return caseField; } set { caseField = value; } }

    /// <remarks />
    [XmlArrayItem("externalRef", typeof(externalRef), IsNullable = false)]
    public externalRef[][] externalReferences
    {
      get { return externalReferencesField; }
      set { externalReferencesField = value; }
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string id { get { return idField; } set { idField = value; } }

    /// <remarks />
    [XmlAttribute]
    public string lemma { get { return lemmaField; } set { lemmaField = value; } }

    /// <remarks />
    [XmlAttribute]
    public string pos { get { return posField; } set { posField = value; } }
  }
}
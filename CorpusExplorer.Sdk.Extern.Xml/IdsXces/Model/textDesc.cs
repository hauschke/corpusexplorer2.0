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
  public class textDesc
  {
    private string columnField;

    private string textDomainField;

    private string textTypeArtField;

    private string textTypeField;

    private string textTypeRefField;

    /// <remarks />
    public string column { get { return columnField; } set { columnField = value; } }

    /// <remarks />
    public string textDomain { get { return textDomainField; } set { textDomainField = value; } }

    /// <remarks />
    public string textType { get { return textTypeField; } set { textTypeField = value; } }

    /// <remarks />
    public string textTypeArt { get { return textTypeArtField; } set { textTypeArtField = value; } }

    /// <remarks />
    public string textTypeRef { get { return textTypeRefField; } set { textTypeRefField = value; } }
  }
}
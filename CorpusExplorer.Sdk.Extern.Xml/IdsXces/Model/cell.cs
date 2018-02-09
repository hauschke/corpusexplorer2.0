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
  public class cell
  {
    private string colsField;

    private string roleField;

    private string rowsField;

    private s sField;

    /// <remarks />
    [XmlAttribute(DataType = "integer")]
    public string cols { get { return colsField; } set { colsField = value; } }

    /// <remarks />
    [XmlAttribute(DataType = "NCName")]
    public string role { get { return roleField; } set { roleField = value; } }

    /// <remarks />
    [XmlAttribute(DataType = "integer")]
    public string rows { get { return rowsField; } set { rowsField = value; } }

    /// <remarks />
    public s s { get { return sField; } set { sField = value; } }
  }
}
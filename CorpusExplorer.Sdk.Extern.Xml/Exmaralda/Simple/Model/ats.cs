#region

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace CorpusExplorer.Sdk.Extern.Xml.Exmaralda.Simple.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.0.30319.33440")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class ats
  {
    private string eField;
    private string idField;
    private atsMedium mediumField;
    private bool mediumFieldSpecified;
    private string nField;
    private string sField;
    private string[] textField;
    private string urlField;

    /// <remarks />
    [XmlAttribute(DataType = "IDREF")]
    public string e
    {
      get => eField;
      set => eField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string id
    {
      get => idField;
      set => idField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public atsMedium medium
    {
      get => mediumField;
      set => mediumField = value;
    }

    /// <remarks />
    [XmlIgnore]
    public bool mediumSpecified
    {
      get => mediumFieldSpecified;
      set => mediumFieldSpecified = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string n
    {
      get => nField;
      set => nField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "IDREF")]
    public string s
    {
      get => sField;
      set => sField = value;
    }

    /// <remarks />
    [XmlText]
    public string[] Text
    {
      get => textField;
      set => textField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string url
    {
      get => urlField;
      set => urlField = value;
    }
  }
}
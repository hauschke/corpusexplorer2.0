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
  public class output
  {
    private outputOO ooField;
    private string prefixField;
    private string suffixField;

    /// <remarks />
    [XmlAttribute]
    public outputOO oo
    {
      get => ooField;
      set => ooField = value;
    }

    /// <remarks />
    public string prefix
    {
      get => prefixField;
      set => prefixField = value;
    }

    /// <remarks />
    public string suffix
    {
      get => suffixField;
      set => suffixField = value;
    }
  }
}
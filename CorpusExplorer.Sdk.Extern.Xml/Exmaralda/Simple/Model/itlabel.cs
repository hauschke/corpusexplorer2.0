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
  [XmlType(AnonymousType = true, Namespace = "http://tempuri.org/interlinear-text")]
  [XmlRoot("it-label", Namespace = "http://tempuri.org/interlinear-text", IsNullable = false)]
  public class itlabel
  {
    private string formatrefField;
    private link[] linkField;
    private run[] runField;
    private udattribute[] udinformationField;

    /// <remarks />
    [XmlAttribute(DataType = "IDREF")]
    public string formatref
    {
      get => formatrefField;
      set => formatrefField = value;
    }

    /// <remarks />
    [XmlElement("link")]
    public link[] link
    {
      get => linkField;
      set => linkField = value;
    }

    /// <remarks />
    [XmlElement("run")]
    public run[] run
    {
      get => runField;
      set => runField = value;
    }

    /// <remarks />
    [XmlArray("ud-information")]
    [XmlArrayItem("ud-attribute", IsNullable = false)]
    public udattribute[] udinformation
    {
      get => udinformationField;
      set => udinformationField = value;
    }
  }
}
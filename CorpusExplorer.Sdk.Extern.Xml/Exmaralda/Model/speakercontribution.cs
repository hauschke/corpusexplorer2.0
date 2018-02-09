#region

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace CorpusExplorer.Sdk.Extern.Xml.Exmaralda.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.0.30319.33440")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot("speaker-contribution", Namespace = "", IsNullable = false)]
  public class speakercontribution
  {
    private string abbreviationField;
    private annotation[] annotationField;
    private string commentField;
    private ats[][] dependentField;
    private string idField;
    private language[] l1Field;
    private language[] l2Field;
    private language[] languagesusedField;
    private main mainField;
    private sex sexField;
    private string speakerField;
    private udinformation[] udspeakerinformationField;

    /// <remarks />
    public string abbreviation { get { return abbreviationField; } set { abbreviationField = value; } }

    /// <remarks />
    [XmlElement("annotation")]
    public annotation[] annotation { get { return annotationField; } set { annotationField = value; } }

    /// <remarks />
    public string comment { get { return commentField; } set { commentField = value; } }

    /// <remarks />
    [XmlArrayItem("ats", typeof(ats), IsNullable = false)]
    public ats[][] dependent { get { return dependentField; } set { dependentField = value; } }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string id { get { return idField; } set { idField = value; } }

    /// <remarks />
    [XmlArrayItem("language", IsNullable = false)]
    public language[] l1 { get { return l1Field; } set { l1Field = value; } }

    /// <remarks />
    [XmlArrayItem("language", IsNullable = false)]
    public language[] l2 { get { return l2Field; } set { l2Field = value; } }

    /// <remarks />
    [XmlArray("languages-used")]
    [XmlArrayItem("language", IsNullable = false)]
    public language[] languagesused { get { return languagesusedField; } set { languagesusedField = value; } }

    /// <remarks />
    public main main { get { return mainField; } set { mainField = value; } }

    /// <remarks />
    public sex sex { get { return sexField; } set { sexField = value; } }

    /// <remarks />
    [XmlAttribute(DataType = "IDREF")]
    public string speaker { get { return speakerField; } set { speakerField = value; } }

    /// <remarks />
    [XmlArray("ud-speaker-information")]
    [XmlArrayItem("ud-information", IsNullable = false)]
    public udinformation[] udspeakerinformation
    {
      get { return udspeakerinformationField; }
      set { udspeakerinformationField = value; }
    }
  }
}
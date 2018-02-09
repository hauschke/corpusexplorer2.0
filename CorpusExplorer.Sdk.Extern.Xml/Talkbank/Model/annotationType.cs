#region

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#endregion

namespace CorpusExplorer.Sdk.Extern.Xml.Talkbank.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.talkbank.org/ns/talkbank")]
  [XmlRoot("a", Namespace = "http://www.talkbank.org/ns/talkbank", IsNullable = false)]
  public class annotationType
  {
    private string flavorField;
    private object[] itemsField;
    private string[] textField;
    private annotationTypeType typeField;
    private bool typeFieldSpecified;
    private string whoField;

    /// <remarks />
    [XmlAttribute]
    public string flavor { get { return flavorField; } set { flavorField = value; } }

    /// <remarks />
    [XmlElement("media", typeof(mediaType))]
    [XmlElement("mediaPic", typeof(mediaPicType))]
    public object[] Items { get { return itemsField; } set { itemsField = value; } }

    /// <remarks />
    [XmlText]
    public string[] Text { get { return textField; } set { textField = value; } }

    /// <remarks />
    [XmlAttribute]
    public annotationTypeType type { get { return typeField; } set { typeField = value; } }

    /// <remarks />
    [XmlIgnore]
    public bool typeSpecified { get { return typeFieldSpecified; } set { typeFieldSpecified = value; } }

    /// <remarks />
    [XmlAttribute]
    public string who { get { return whoField; } set { whoField = value; } }
  }
}
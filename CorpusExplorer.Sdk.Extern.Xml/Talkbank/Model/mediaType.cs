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
  [XmlRoot("internal-media", Namespace = "http://www.talkbank.org/ns/talkbank", IsNullable = false)]
  public class mediaType
  {
    private decimal endField;
    private bool skipField;
    private bool skipFieldSpecified;
    private decimal startField;
    private mediaUnitType unitField;

    /// <remarks />
    [XmlAttribute]
    public decimal end { get { return endField; } set { endField = value; } }

    /// <remarks />
    [XmlAttribute]
    public bool skip { get { return skipField; } set { skipField = value; } }

    /// <remarks />
    [XmlIgnore]
    public bool skipSpecified { get { return skipFieldSpecified; } set { skipFieldSpecified = value; } }

    /// <remarks />
    [XmlAttribute]
    public decimal start { get { return startField; } set { startField = value; } }

    /// <remarks />
    [XmlAttribute]
    public mediaUnitType unit { get { return unitField; } set { unitField = value; } }
  }
}
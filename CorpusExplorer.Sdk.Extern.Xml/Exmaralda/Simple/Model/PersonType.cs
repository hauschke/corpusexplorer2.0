#region

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

#endregion

namespace CorpusExplorer.Sdk.Extern.Xml.Exmaralda.Simple.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.0.30319.33440")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  public class PersonType
  {
    private string idField;
    private ItemsChoiceType[] itemsElementNameField;
    private object[] itemsField;

    /// <remarks />
    [XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "ID")]
    public string Id
    {
      get => idField;
      set => idField = value;
    }

    /// <remarks />
    [XmlElement("AsocFile", typeof(AsocFileType))]
    [XmlElement("Description", typeof(DescriptionType))]
    [XmlElement("KnownHuman", typeof(bool))]
    [XmlElement("Language", typeof(LanguageType))]
    [XmlElement("Location", typeof(LocationType))]
    [XmlElement("Pseudo", typeof(string))]
    [XmlElement("Sex", typeof(string))]
    [XmlElement("Sigle", typeof(string))]
    [XmlElement("role", typeof(roleType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
      get => itemsField;
      set => itemsField = value;
    }

    /// <remarks />
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType[] ItemsElementName
    {
      get => itemsElementNameField;
      set => itemsElementNameField = value;
    }
  }
}
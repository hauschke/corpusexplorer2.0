﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.Pmg.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.6.1055.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true)]
  [XmlRoot(Namespace = "", IsNullable = false)]
  public class abbildung
  {
    private Inline beschriftungField;

    private string fotografField;

    private string fotonachweisField;

    private ItemChoiceType itemElementNameField;

    private string itemField;

    /// <remarks />
    public Inline beschriftung { get { return beschriftungField; } set { beschriftungField = value; } }

    /// <remarks />
    public string fotograf { get { return fotografField; } set { fotografField = value; } }

    /// <remarks />
    public string fotonachweis { get { return fotonachweisField; } set { fotonachweisField = value; } }

    /// <remarks />
    [XmlElement("bild", typeof(string))]
    [XmlElement("foto", typeof(string))]
    [XmlElement("infografik", typeof(string))]
    [XmlChoiceIdentifier("ItemElementName")]
    public string Item { get { return itemField; } set { itemField = value; } }

    /// <remarks />
    [XmlIgnore]
    public ItemChoiceType ItemElementName { get { return itemElementNameField; } set { itemElementNameField = value; } }
  }
}
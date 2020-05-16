﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Wiki.WikipediaMetaTalk.Model
{
  /// <remarks />
  [GeneratedCode("xsd", "4.6.1055.0")]
  [Serializable]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true,
    Namespace = "http://www.mediawiki.org/xml/export-0.10/")]
  [XmlRoot(Namespace = "http://www.mediawiki.org/xml/export-0.10/",
    IsNullable = false)]
  public class comment
  {
    private string deletedField;

    private string[] textField;

    /// <remarks />
    [XmlAttribute(DataType = "NCName")]
    public string deleted
    {
      get => deletedField;
      set => deletedField = value;
    }

    /// <remarks />
    [XmlText]
    public string[] Text
    {
      get => textField;
      set => textField = value;
    }
  }
}
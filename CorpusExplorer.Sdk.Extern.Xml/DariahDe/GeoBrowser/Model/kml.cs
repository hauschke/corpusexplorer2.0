﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace CorpusExplorer.Sdk.Extern.Xml.DariahDe.GeoBrowser.Model
{ // 
  // Dieser Quellcode wurde automatisch generiert von xsd, Version=4.6.1055.0.
  // 


  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [XmlType(AnonymousType=true)]
  [XmlRoot(Namespace="", IsNullable=false)]
  public partial class kml {
    
    private Placemark[] placemarkField;
    
    /// <remarks/>
    [XmlElement("Placemark")]
    public Placemark[] Placemark {
      get {
        return this.placemarkField;
      }
      set {
        this.placemarkField = value;
      }
    }
  }
}
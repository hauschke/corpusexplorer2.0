﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("tierformat-table", Namespace="", IsNullable=false)]
public partial class tierformattable {
    
    private referencedfile[] referencedfileField;
    
    private timelineitemformat[] timelineitemformatField;
    
    private tierformat[] tierformatField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("referenced-file")]
    public referencedfile[] referencedfile {
        get {
            return this.referencedfileField;
        }
        set {
            this.referencedfileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeline-item-format")]
    public timelineitemformat[] timelineitemformat {
        get {
            return this.timelineitemformatField;
        }
        set {
            this.timelineitemformatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tier-format")]
    public tierformat[] tierformat {
        get {
            return this.tierformatField;
        }
        set {
            this.tierformatField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("referenced-file", Namespace="", IsNullable=false)]
public partial class referencedfile {
    
    private string urlField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string url {
        get {
            return this.urlField;
        }
        set {
            this.urlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("timeline-item-format", Namespace="", IsNullable=false)]
public partial class timelineitemformat {
    
    private string showeverynthnumberingField;
    
    private string showeverynthabsoluteField;
    
    private timelineitemformatAbsolutetimeformat absolutetimeformatField;
    
    private bool absolutetimeformatFieldSpecified;
    
    private string milisecondsdigitsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("show-every-nth-numbering")]
    public string showeverynthnumbering {
        get {
            return this.showeverynthnumberingField;
        }
        set {
            this.showeverynthnumberingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("show-every-nth-absolute")]
    public string showeverynthabsolute {
        get {
            return this.showeverynthabsoluteField;
        }
        set {
            this.showeverynthabsoluteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("absolute-time-format")]
    public timelineitemformatAbsolutetimeformat absolutetimeformat {
        get {
            return this.absolutetimeformatField;
        }
        set {
            this.absolutetimeformatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool absolutetimeformatSpecified {
        get {
            return this.absolutetimeformatFieldSpecified;
        }
        set {
            this.absolutetimeformatFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("miliseconds-digits")]
    public string milisecondsdigits {
        get {
            return this.milisecondsdigitsField;
        }
        set {
            this.milisecondsdigitsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum timelineitemformatAbsolutetimeformat {
    
    /// <remarks/>
    @decimal,
    
    /// <remarks/>
    time,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("tier-format", Namespace="", IsNullable=false)]
public partial class tierformat {
    
    private property[] propertyField;
    
    private string[] textField;
    
    private string tierrefField;
    
    private tierformatStylename stylenameField;
    
    private bool stylenameFieldSpecified;
    
    private tierformatSize sizeField;
    
    private bool sizeFieldSpecified;
    
    private tierformatAlignmentname alignmentnameField;
    
    private bool alignmentnameFieldSpecified;
    
    private tierformatTextcolorname textcolornameField;
    
    private bool textcolornameFieldSpecified;
    
    private tierformatBgcolorname bgcolornameField;
    
    private bool bgcolornameFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public property[] property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string tierref {
        get {
            return this.tierrefField;
        }
        set {
            this.tierrefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("style-name")]
    public tierformatStylename stylename {
        get {
            return this.stylenameField;
        }
        set {
            this.stylenameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stylenameSpecified {
        get {
            return this.stylenameFieldSpecified;
        }
        set {
            this.stylenameFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public tierformatSize size {
        get {
            return this.sizeField;
        }
        set {
            this.sizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeSpecified {
        get {
            return this.sizeFieldSpecified;
        }
        set {
            this.sizeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("alignment-name")]
    public tierformatAlignmentname alignmentname {
        get {
            return this.alignmentnameField;
        }
        set {
            this.alignmentnameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool alignmentnameSpecified {
        get {
            return this.alignmentnameFieldSpecified;
        }
        set {
            this.alignmentnameFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("textcolor-name")]
    public tierformatTextcolorname textcolorname {
        get {
            return this.textcolornameField;
        }
        set {
            this.textcolornameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool textcolornameSpecified {
        get {
            return this.textcolornameFieldSpecified;
        }
        set {
            this.textcolornameFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("bgcolor-name")]
    public tierformatBgcolorname bgcolorname {
        get {
            return this.bgcolornameField;
        }
        set {
            this.bgcolornameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bgcolornameSpecified {
        get {
            return this.bgcolornameFieldSpecified;
        }
        set {
            this.bgcolornameFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class property {
    
    private propertyName nameField;
    
    private string[] textField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public propertyName name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum propertyName {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("font-color")]
    fontcolor,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("bg-color")]
    bgcolor,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("font-size")]
    fontsize,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("font-name")]
    fontname,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("font-face")]
    fontface,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("chunk-border")]
    chunkborder,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("chunk-border-color")]
    chunkbordercolor,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("chunk-border-style")]
    chunkborderstyle,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("text-alignment")]
    textalignment,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("row-height-calculation")]
    rowheightcalculation,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("fixed-row-height")]
    fixedrowheight,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum tierformatStylename {
    
    /// <remarks/>
    Plain,
    
    /// <remarks/>
    Bold,
    
    /// <remarks/>
    Italic,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum tierformatSize {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("7")]
    Item7,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("8")]
    Item8,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("9")]
    Item9,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("12")]
    Item12,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("13")]
    Item13,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("14")]
    Item14,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("15")]
    Item15,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("16")]
    Item16,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("17")]
    Item17,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("18")]
    Item18,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("19")]
    Item19,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("20")]
    Item20,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("21")]
    Item21,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("22")]
    Item22,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("23")]
    Item23,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("24")]
    Item24,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("25")]
    Item25,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("26")]
    Item26,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("27")]
    Item27,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("28")]
    Item28,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("29")]
    Item29,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("30")]
    Item30,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("31")]
    Item31,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("32")]
    Item32,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("33")]
    Item33,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("34")]
    Item34,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("35")]
    Item35,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("36")]
    Item36,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("37")]
    Item37,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("38")]
    Item38,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("39")]
    Item39,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("40")]
    Item40,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("41")]
    Item41,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("42")]
    Item42,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("43")]
    Item43,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("44")]
    Item44,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("45")]
    Item45,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("46")]
    Item46,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("47")]
    Item47,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("48")]
    Item48,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("72")]
    Item72,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum tierformatAlignmentname {
    
    /// <remarks/>
    Left,
    
    /// <remarks/>
    Right,
    
    /// <remarks/>
    Center,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum tierformatTextcolorname {
    
    /// <remarks/>
    white,
    
    /// <remarks/>
    lightGray,
    
    /// <remarks/>
    darkGray,
    
    /// <remarks/>
    black,
    
    /// <remarks/>
    red,
    
    /// <remarks/>
    pink,
    
    /// <remarks/>
    orange,
    
    /// <remarks/>
    yellow,
    
    /// <remarks/>
    green,
    
    /// <remarks/>
    magenta,
    
    /// <remarks/>
    cyan,
    
    /// <remarks/>
    blue,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public enum tierformatBgcolorname {
    
    /// <remarks/>
    white,
    
    /// <remarks/>
    lightGray,
    
    /// <remarks/>
    darkGray,
    
    /// <remarks/>
    black,
    
    /// <remarks/>
    red,
    
    /// <remarks/>
    pink,
    
    /// <remarks/>
    orange,
    
    /// <remarks/>
    yellow,
    
    /// <remarks/>
    green,
    
    /// <remarks/>
    magenta,
    
    /// <remarks/>
    cyan,
    
    /// <remarks/>
    blue,
}

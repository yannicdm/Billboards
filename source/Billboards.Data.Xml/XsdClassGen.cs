﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Billboards.Data.Xml {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/kml/2.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.opengis.net/kml/2.2", IsNullable=false)]
    public partial class kml {
        
        private kmlPlacemark[] documentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Placemark", IsNullable=false)]
        public kmlPlacemark[] Document {
            get {
                return this.documentField;
            }
            set {
                this.documentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/kml/2.2")]
    public partial class kmlPlacemark {
        
        private byte nameField;
        
        private string descriptionField;
        
        private kmlPlacemarkData[] extendedDataField;
        
        private kmlPlacemarkPoint pointField;
        
        /// <remarks/>
        public byte name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Data", IsNullable=false)]
        public kmlPlacemarkData[] ExtendedData {
            get {
                return this.extendedDataField;
            }
            set {
                this.extendedDataField = value;
            }
        }
        
        /// <remarks/>
        public kmlPlacemarkPoint Point {
            get {
                return this.pointField;
            }
            set {
                this.pointField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/kml/2.2")]
    public partial class kmlPlacemarkData {
        
        private string valueField;
        
        private string nameField;
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18034")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opengis.net/kml/2.2")]
    public partial class kmlPlacemarkPoint {
        
        private string coordinatesField;
        
        /// <remarks/>
        public string coordinates {
            get {
                return this.coordinatesField;
            }
            set {
                this.coordinatesField = value;
            }
        }
    }
}

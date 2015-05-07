using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class animeapi
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Results
        {

            private ResultsShow[] showField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("show")]
            public ResultsShow[] show
            {
                get
                {
                    return this.showField;
                }
                set
                {
                    this.showField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ResultsShow
        {

            private ushort showidField;

            private string nameField;

            private string linkField;

            private string countryField;

            private string startedField;

            private string endedField;

            private byte seasonsField;

            private string statusField;

            private byte runtimeField;

            private string classificationField;

            private string[] genresField;

            private ResultsShowNetwork networkField;

            private string airtimeField;

            private string airdayField;

            private ResultsShowAka[] akasField;

            /// <remarks/>
            public ushort showid
            {
                get
                {
                    return this.showidField;
                }
                set
                {
                    this.showidField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public string country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            public string started
            {
                get
                {
                    return this.startedField;
                }
                set
                {
                    this.startedField = value;
                }
            }

            /// <remarks/>
            public string ended
            {
                get
                {
                    return this.endedField;
                }
                set
                {
                    this.endedField = value;
                }
            }

            /// <remarks/>
            public byte seasons
            {
                get
                {
                    return this.seasonsField;
                }
                set
                {
                    this.seasonsField = value;
                }
            }

            /// <remarks/>
            public string status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public byte runtime
            {
                get
                {
                    return this.runtimeField;
                }
                set
                {
                    this.runtimeField = value;
                }
            }

            /// <remarks/>
            public string classification
            {
                get
                {
                    return this.classificationField;
                }
                set
                {
                    this.classificationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("genre", IsNullable = false)]
            public string[] genres
            {
                get
                {
                    return this.genresField;
                }
                set
                {
                    this.genresField = value;
                }
            }

            /// <remarks/>
            public ResultsShowNetwork network
            {
                get
                {
                    return this.networkField;
                }
                set
                {
                    this.networkField = value;
                }
            }

            /// <remarks/>
            public string airtime
            {
                get
                {
                    return this.airtimeField;
                }
                set
                {
                    this.airtimeField = value;
                }
            }

            /// <remarks/>
            public string airday
            {
                get
                {
                    return this.airdayField;
                }
                set
                {
                    this.airdayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("aka", IsNullable = false)]
            public ResultsShowAka[] akas
            {
                get
                {
                    return this.akasField;
                }
                set
                {
                    this.akasField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ResultsShowNetwork
        {

            private string countryField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ResultsShowAka
        {

            private string attrField;

            private string countryField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string attr
            {
                get
                {
                    return this.attrField;
                }
                set
                {
                    this.attrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        
    }
}
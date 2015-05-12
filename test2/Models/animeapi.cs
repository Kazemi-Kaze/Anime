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
        public partial class Data
        {

            private DataSeries[] seriesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Series")]
            public DataSeries[] Series
            {
                get
                {
                    return this.seriesField;
                }
                set
                {
                    this.seriesField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DataSeries
        {

            private uint seriesidField;

            private string languageField;

            private string seriesNameField;

            private string bannerField;

            private string overviewField;

            private System.DateTime firstAiredField;

            private string networkField;

            private string iMDB_IDField;

            private string zap2it_idField;

            private uint idField;

            /// <remarks/>
            public uint seriesid
            {
                get
                {
                    return this.seriesidField;
                }
                set
                {
                    this.seriesidField = value;
                }
            }

            /// <remarks/>
            public string language
            {
                get
                {
                    return this.languageField;
                }
                set
                {
                    this.languageField = value;
                }
            }

            /// <remarks/>
            public string SeriesName
            {
                get
                {
                    return this.seriesNameField;
                }
                set
                {
                    this.seriesNameField = value;
                }
            }

            /// <remarks/>
            public string banner
            {
                get
                {
                    return this.bannerField;
                }
                set
                {
                    this.bannerField = value;
                }
            }

            /// <remarks/>
            public string Overview
            {
                get
                {
                    return this.overviewField;
                }
                set
                {
                    this.overviewField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime FirstAired
            {
                get
                {
                    return this.firstAiredField;
                }
                set
                {
                    this.firstAiredField = value;
                }
            }

            /// <remarks/>
            public string Network
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
            public string IMDB_ID
            {
                get
                {
                    return this.iMDB_IDField;
                }
                set
                {
                    this.iMDB_IDField = value;
                }
            }

            /// <remarks/>
            public string zap2it_id
            {
                get
                {
                    return this.zap2it_idField;
                }
                set
                {
                    this.zap2it_idField = value;
                }
            }

            /// <remarks/>
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }



        
    }
}
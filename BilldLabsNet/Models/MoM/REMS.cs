using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilldLabsNet.Models.MoM
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class weather_report
    {

        private string titleField;

        private string linkField;

        private weather_reportDisclaimer disclaimerField;

        private ushort solField;

        private weather_reportSol_desc sol_descField;

        private string terrestrial_dateField;

        private weather_reportTerrestrial_date_desc terrestrial_date_descField;

        private weather_reportMagnitudes magnitudesField;

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
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
        public weather_reportDisclaimer disclaimer
        {
            get
            {
                return this.disclaimerField;
            }
            set
            {
                this.disclaimerField = value;
            }
        }

        /// <remarks/>
        public ushort sol
        {
            get
            {
                return this.solField;
            }
            set
            {
                this.solField = value;
            }
        }

        /// <remarks/>
        public weather_reportSol_desc sol_desc
        {
            get
            {
                return this.sol_descField;
            }
            set
            {
                this.sol_descField = value;
            }
        }

        /// <remarks/>
        public string terrestrial_date
        {
            get
            {
                return this.terrestrial_dateField;
            }
            set
            {
                this.terrestrial_dateField = value;
            }
        }

        /// <remarks/>
        public weather_reportTerrestrial_date_desc terrestrial_date_desc
        {
            get
            {
                return this.terrestrial_date_descField;
            }
            set
            {
                this.terrestrial_date_descField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudes magnitudes
        {
            get
            {
                return this.magnitudesField;
            }
            set
            {
                this.magnitudesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportDisclaimer
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportSol_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportTerrestrial_date_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudes
    {

        private sbyte min_tempField;

        private sbyte max_tempField;

        private weather_reportMagnitudesTemp_desc temp_descField;

        private ushort pressureField;

        private string pressure_stringField;

        private weather_reportMagnitudesPressure_desc pressure_descField;

        private string abs_humidityField;

        private weather_reportMagnitudesAbs_humidity_desc abs_humidity_descField;

        private string wind_speedField;

        private string wind_directionField;

        private weather_reportMagnitudesWind_desc wind_descField;

        private sbyte min_gts_tempField;

        private sbyte max_gts_tempField;

        private weather_reportMagnitudesGts_temp_desc gts_temp_descField;

        private string local_uv_irradiance_indexField;

        private weather_reportMagnitudesLocal_uv_irradiance_index_desc local_uv_irradiance_index_descField;

        private string atmo_opacityField;

        private weather_reportMagnitudesAtmo_opacity_des atmo_opacity_desField;

        private byte lsField;

        private weather_reportMagnitudesLs_desc ls_descField;

        private string seasonField;

        private weather_reportMagnitudesSeason_desc season_descField;

        private string sunriseField;

        private string sunsetField;

        private weather_reportMagnitudesSunrise_sunset_desc sunrise_sunset_descField;

        /// <remarks/>
        public sbyte min_temp
        {
            get
            {
                return this.min_tempField;
            }
            set
            {
                this.min_tempField = value;
            }
        }

        /// <remarks/>
        public sbyte max_temp
        {
            get
            {
                return this.max_tempField;
            }
            set
            {
                this.max_tempField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesTemp_desc temp_desc
        {
            get
            {
                return this.temp_descField;
            }
            set
            {
                this.temp_descField = value;
            }
        }

        /// <remarks/>
        public ushort pressure
        {
            get
            {
                return this.pressureField;
            }
            set
            {
                this.pressureField = value;
            }
        }

        /// <remarks/>
        public string pressure_string
        {
            get
            {
                return this.pressure_stringField;
            }
            set
            {
                this.pressure_stringField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesPressure_desc pressure_desc
        {
            get
            {
                return this.pressure_descField;
            }
            set
            {
                this.pressure_descField = value;
            }
        }

        /// <remarks/>
        public string abs_humidity
        {
            get
            {
                return this.abs_humidityField;
            }
            set
            {
                this.abs_humidityField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesAbs_humidity_desc abs_humidity_desc
        {
            get
            {
                return this.abs_humidity_descField;
            }
            set
            {
                this.abs_humidity_descField = value;
            }
        }

        /// <remarks/>
        public string wind_speed
        {
            get
            {
                return this.wind_speedField;
            }
            set
            {
                this.wind_speedField = value;
            }
        }

        /// <remarks/>
        public string wind_direction
        {
            get
            {
                return this.wind_directionField;
            }
            set
            {
                this.wind_directionField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesWind_desc wind_desc
        {
            get
            {
                return this.wind_descField;
            }
            set
            {
                this.wind_descField = value;
            }
        }

        /// <remarks/>
        public sbyte min_gts_temp
        {
            get
            {
                return this.min_gts_tempField;
            }
            set
            {
                this.min_gts_tempField = value;
            }
        }

        /// <remarks/>
        public sbyte max_gts_temp
        {
            get
            {
                return this.max_gts_tempField;
            }
            set
            {
                this.max_gts_tempField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesGts_temp_desc gts_temp_desc
        {
            get
            {
                return this.gts_temp_descField;
            }
            set
            {
                this.gts_temp_descField = value;
            }
        }

        /// <remarks/>
        public string local_uv_irradiance_index
        {
            get
            {
                return this.local_uv_irradiance_indexField;
            }
            set
            {
                this.local_uv_irradiance_indexField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesLocal_uv_irradiance_index_desc local_uv_irradiance_index_desc
        {
            get
            {
                return this.local_uv_irradiance_index_descField;
            }
            set
            {
                this.local_uv_irradiance_index_descField = value;
            }
        }

        /// <remarks/>
        public string atmo_opacity
        {
            get
            {
                return this.atmo_opacityField;
            }
            set
            {
                this.atmo_opacityField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesAtmo_opacity_des atmo_opacity_des
        {
            get
            {
                return this.atmo_opacity_desField;
            }
            set
            {
                this.atmo_opacity_desField = value;
            }
        }

        /// <remarks/>
        public byte ls
        {
            get
            {
                return this.lsField;
            }
            set
            {
                this.lsField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesLs_desc ls_desc
        {
            get
            {
                return this.ls_descField;
            }
            set
            {
                this.ls_descField = value;
            }
        }

        /// <remarks/>
        public string season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesSeason_desc season_desc
        {
            get
            {
                return this.season_descField;
            }
            set
            {
                this.season_descField = value;
            }
        }

        /// <remarks/>
        public string sunrise
        {
            get
            {
                return this.sunriseField;
            }
            set
            {
                this.sunriseField = value;
            }
        }

        /// <remarks/>
        public string sunset
        {
            get
            {
                return this.sunsetField;
            }
            set
            {
                this.sunsetField = value;
            }
        }

        /// <remarks/>
        public weather_reportMagnitudesSunrise_sunset_desc sunrise_sunset_desc
        {
            get
            {
                return this.sunrise_sunset_descField;
            }
            set
            {
                this.sunrise_sunset_descField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesTemp_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesPressure_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesAbs_humidity_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesWind_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesGts_temp_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesLocal_uv_irradiance_index_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesAtmo_opacity_des
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesLs_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesSeason_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class weather_reportMagnitudesSunrise_sunset_desc
    {

        private string enField;

        private string esField;

        /// <remarks/>
        public string en
        {
            get
            {
                return this.enField;
            }
            set
            {
                this.enField = value;
            }
        }

        /// <remarks/>
        public string es
        {
            get
            {
                return this.esField;
            }
            set
            {
                this.esField = value;
            }
        }
    }


}
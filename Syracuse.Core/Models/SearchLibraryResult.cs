using System;
using System.Collections.Generic;
using MvvmCross.Binding.Extensions;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Syracuse.Mobitheque.Core.Models
{
    public class SearchLibraryResult
    {
        public IList<object> errors { get; set; }
        public string message { get; set; }
        public bool success { get; set; }

        [JsonProperty("d")]
        public Dataa Dataa { get; set; }
            
    }

    public class HoldingPlace
    {
        public string Code { get; set; }
        public bool IsDefault { get; set; }
        public string Libelle { get; set; }
        public string TopLevelScopeCode { get; set; }
    }
    public class HoldingColumn
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Style { get; set; }
        public List<KeyValue> Labels { get; set; }
        public string ColumnLabel { get; set; }
        public string ColumnLabelKey { get; set; }
        public bool DesktopVisible { get; set; }
        public bool MobileVisible { get; set; }
        public bool CanSort { get; set; }
        public bool IsDefaultSort { get; set; }
        public string ColumnType { get; set; }


    }

    public class HoldingsStatementColumn
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Style { get; set; }
        public List<KeyValue> Labels { get; set; }
        public string ColumnLabel { get; set; }
        public string ColumnLabelKey { get; set; }
        public bool DesktopVisible { get; set; }
        public bool MobileVisible { get; set; }
        public bool CanSort { get; set; }
        public bool IsDefaultSort { get; set; }
        public string ColumnType { get; set; }
    }
    public class ItemHoldingsData
    {
        public int Availability { get; set; }
        public object Docbase { get; set; }
        public bool Error { get; set; }
        public object ErrorMessage { get; set; }
        public string HoldingLabel { get; set; }
        public string Id { get; set; }
        public object Mode { get; set; }
        public string RecordId { get; set; }
        public object WhenHoldBack { get; set; }
    }

    public class FieldListData
    {
        public IList<string> Identifier { get; set; }
        public IList<string> Title { get; set; }
        public IList<string> Title_sort { get; set; }
        public IList<string> DateOfPublication_sort { get; set; }
        public IList<string> TypeOfDocument { get; set; }
        public IList<string> TypeOfDocument_idx { get; set; }
        public IList<string> TypeOfDocument_ils { get; set; }
        public IList<string> sys_support { get; set; }
        public IList<string> Popularity_sort { get; set; }
        public IList<string> sys_base { get; set; }

    }
    public class Holdings
    {
        [JsonProperty("AlternativeCote")]
        public object AlternativeCote { get; set; }
        [JsonProperty("Barcode")]
        public string Barcode { get; set; }
        [JsonProperty("BaseName")]
        public string BaseName { get; set; }
        [JsonProperty("BookingTooltip")]
        public string BookingTooltip { get; set; }
        [JsonProperty("BookingTooltipCode")]
        public string BookingTooltipCode { get; set; }
        [JsonProperty("Category")]
        public object Category { get; set; }
        [JsonProperty("Cote")]
        public string Cote { get; set; }
        [JsonProperty("HoldingId")]
        public string HoldingId { get; set; }
        [JsonProperty("HoldingPlace")]
        public object HoldingPlace { get; set; }
        [JsonProperty("IncludedInSubscription")]
        public bool IncludedInSubscription { get; set; }
        [JsonProperty("InfoTooltip")]
        public string InfoTooltip { get; set; }
        [JsonProperty("IsAvailable")]
        public bool IsAvailable { get; set; }
        [JsonProperty("IsExpo")]
        public bool IsExpo { get; set; }
        [JsonProperty("IsLoanable")]
        public bool IsLoanable { get; set; }
        [JsonProperty("IsReservable")]
        public bool IsReservable { get; set; }
        [JsonProperty("IsSerial")]
        public bool IsSerial { get; set; }
        [JsonProperty("IsTransmissible")]
        public bool IsTransmissible { get; set; }
        [JsonProperty("LibFas")]
        public object LibFas { get; set; }
        [JsonProperty("Localisation")]
        public string Localisation { get; set; }
        [JsonProperty("NbResa")]
        public int NbResa { get; set; }
        [JsonProperty("NewItem")]
        public bool NewItem { get; set; }
        [JsonProperty("Other")]
        public List<object> Other { get; set; }
        [JsonProperty("Place")]
        public string Place { get; set; }
        [JsonProperty("RecordId")]
        public string RecordId { get; set; }
        [JsonProperty("Resa")]
        public string Resa { get; set; }
        [JsonProperty("ReservationMode")]
        public int ReservationMode { get; set; }
        [JsonProperty("Section")]
        public string Section { get; set; }
        [JsonProperty("SectionCode")]
        public string SectionCode { get; set; }
        [JsonProperty("Site")]
        public string Site { get; set; }
        [JsonProperty("SiteCode")]
        public string SiteCode { get; set; }
        [JsonProperty("SourceType")]
        public int SourceType { get; set; }
        [JsonProperty("Statut")]
        public string Statut { get; set; }
        [JsonProperty("TopLevelScope")]
        public string TopLevelScope { get; set; }
        [JsonProperty("TopLevelScopeCode")]
        public string TopLevelScopeCode { get; set; }
        [JsonProperty("Type")]
        public string Type { get; set; }
        [JsonProperty("WhenBack")]
        public string WhenBack { get; set; }
        public bool IsHaveWhenBack
        {
            get
            {
                return !String.IsNullOrEmpty(WhenBack);
            }
        }
        public string StatusColor 
        {
            get
            {
                if (Statut == "En rayon")
                {
                    return "#97c67d";
                }
                return "#fdc76b";
            }
        }
        public Dictionary<string, bool> DisplayHoldings { get; set; }
        public string DisplayValue { get; set; }
        public string DisponibilityText { get; set; }
    }
    //public class Holdings
    //{
    //    [JsonProperty("Barcode")]
    //    public string Barcode { get; set; } = "";

    //    [JsonProperty("BookingTooltip")]
    //    public string BookingTooltip { get; set; } = "";

    //    [JsonProperty("Cote")]
    //    public string Cote { get; set; } = "";

    //    [JsonProperty("Site")]
    //    public string Site { get; set; } = "";

    //    [JsonProperty("SiteCode")]
    //    public string SiteCode { get; set; } = "";

    //    [JsonProperty("Localisation")]
    //    public object Localisation { get; set; }

    //    [JsonProperty("WhenBack")]
    //    public string WhenBack { get; set; }

    //    public bool IsHaveWhenBack
    //    {
    //        get
    //        {
    //           return !String.IsNullOrEmpty(WhenBack);
    //        }
    //    }

    //    [JsonProperty("Type")]
    //    public string Type { get; set; } = "";

    //    [JsonProperty("Section")]
    //    public string Section { get; set; }

    //    [JsonProperty("Statut")]
    //    public string Statut { get; set; } = "";

    //    [JsonProperty("Holdingid")]
    //    public string Holdingid { get; set; } = "";

    //    [JsonProperty("RecordId")]
    //    public string RecordId { get; set; } = "";

    //    [JsonProperty("BaseName")]
    //    public string BaseName { get; set; } = "";

    //    [JsonProperty("isReservable")]
    //    public bool isReservable { get; set; } = false;

    //    public string StatusColor
    //    {
    //        get
    //        {
    //            if (Statut == "En rayon")
    //            {
    //                return "#97c67d";
    //            }
    //            return "#fdc76b";
    //        }
    //    }
    //    public Dictionary<string, bool> DisplayHoldings { get; set; }
    //    public string DisplayValue { get; set; }
    //    public string DisponibilityText { get; set; }

    //}

    public class HoldingsStatement
    {
        /// <summary>
        /// Site de gestion (bibliothèque, etc.)
        /// </summary>
        [JsonProperty("Site")]
        public string Site { get; set; }
        /// <summary>
        /// Localisation (ex : étagère, étage, etc.)
        /// </summary>
        [JsonProperty("Localisation")]
        public object Localisation { get; set; }
        /// <summary>
        /// Type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type { get; set; }
        /// <summary>
        /// Section (ex : Adulte, jeunesse)
        /// </summary>
        [JsonProperty("Section")]
        public string Section { get; set; }
        /// <summary>
        /// Cote (ex : 784.1 AYO, I 2.3.5.1)
        /// </summary>
        [JsonProperty("Cote")]
        public string Cote { get; set; }

        /// <summary>
        /// Cote alternative.
        /// </summary>
        [JsonProperty("AlternativeCote")]
        public string AlternativeCote { get; set; }

        /// <summary>
        /// Date de début.
        /// </summary>
        [JsonProperty("WhenStart")]
        public string WhenStart { get; set; }

        /// <summary>
        /// Date de fin.
        /// </summary>
        [JsonProperty("WhenEnd")]
        public string WhenEnd { get; set; }

        /// <summary>
        /// Numéro du début de l'état.
        /// </summary>
        [JsonProperty("StartNumber")]
        public string StartNumber { get; internal set; }

        /// <summary>
        /// Date de début en version textuelle.
        /// </summary>
        [JsonProperty("WhenStartAsText")]
        public string WhenStartAsText { get; internal set; }

        /// <summary>
        /// Numéro de fin.
        /// </summary>
        [JsonProperty("EndNumber")]
        public string EndNumber { get; internal set; }

        /// <summary>
        /// Date de fin en version textuelle.
        /// </summary>
        [JsonProperty("WhenEndAsText")]
        public string WhenEndAsText { get; internal set; }

        /// <summary>
        /// Lacunes de l'état de collection.
        /// </summary>
        [JsonProperty("Gap")]
        public string Gap { get; internal set; }

        /// <summary>
        /// Description textuelle de la couverture de l'état de collection.
        /// </summary>
        [JsonProperty("Range")]
        public string Range { get; internal set; }

        /// <summary>
        /// Type de support. Physique ou electronique.
        /// </summary>
        [JsonProperty("Support")]
        public string Support { get; internal set; }

        /// <summary>
        /// Si electronique, url pour acceder à la ressource.
        /// </summary>
        [JsonProperty("Url")]
        public string Url { get; internal set; }

        public Dictionary<string, bool> DisplayHoldingsStatements { get; set; }

        public string DisplayValue { get; set; }
    }
    public class Dataa
    {
        public IList<HoldingColumn> HoldingColumns { get; set; }
        public IList<HoldingPlace> HoldingPlaces { get; set; }

        [JsonProperty("Holdings")]
        public List<Holdings> Holdings { get; set; }
        public bool IsHoldings
        {
            get
            {
                return Holdings.Count > 0 && Holdings != null;
            }
        }
        public Dictionary<string, bool> DisplayHoldings
        {
            get
            {
                Dictionary<string, bool> result = new Dictionary<string, bool>();
                foreach (var item in HoldingColumns)
                {
                    result.Add(item.Name, item.MobileVisible);
                }
                return result;
            }
        }
        public IList<HoldingsStatementColumn> HoldingsStatementColumns { get; set; }
        [JsonProperty("HoldingsStatements")]
        public List<HoldingsStatement> HoldingsStatements { get; set; }
        public bool IsHoldingsStatements
        {
            get
            {
                return HoldingsStatements.Count > 0 && HoldingsStatements != null;
            }
        }

        public Dictionary<string, bool> DisplayHoldingsStatements
        {
            get
            {
                Dictionary<string, bool> result = new Dictionary<string, bool>();
                foreach (var item in HoldingsStatementColumns)
                {
                    result.Add(item.Name, item.MobileVisible);
                }
                return result;
            }
        }
        public object HtmlView { get; set; }
        public ItemHoldingsData ItemHoldingsData { get; set; }
        public string ItemHoldinsDataHtmlView { get; set; }
        public object LocationSiteRestriction { get; set; }
        public object MailFormUrl { get; set; }
        public bool MultiStepReservation { get; set; }
        public object ReservationAlerts { get; set; }
        public int ReservationMode { get; set; }
        public string SearchType { get; set; }
        public int SourceType { get; set; }
        public bool TitleReservable { get; set; }
        public bool UserSubscriptionAvailable { get; set; }

        [JsonProperty("FieldList")]
        public FieldListData fieldList { get; set; }
    }
}
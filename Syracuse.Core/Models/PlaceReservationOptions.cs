using System;
using System.Collections.Generic;

namespace Syracuse.Mobitheque.Core.Models
{
    public class HoldingItem
    {
        public HoldingItem(Holdings data)
        {
            AlternativeCote = data.AlternativeCote;
            Barcode = data.Barcode;
            BaseName = data.BaseName;
            BookingTooltip = data.BookingTooltip;
            BookingTooltipCode = data.BookingTooltipCode;
            Category = data.Category;
            Cote = data.Cote;
            HoldingId = data.HoldingId;
            HoldingPlace = data.SiteCode;
            IncludedInSubscription = data.IncludedInSubscription;
            InfoTooltip = data.InfoTooltip;
            IsAvailable = data.IsAvailable;
            IsExpo = data.IsExpo;
            IsLoanable = data.IsLoanable;
            IsReservable = data.IsReservable;
            IsSerial = data.IsSerial;
            IsTransmissible = data.IsTransmissible;
            LibFas = data.LibFas;
            Localisation = data.Localisation;
            NbResa = data.NbResa;
            NewItem = data.NewItem;
            Other = data.Other;
            Place = data.Place;
            RecordId = data.RecordId;
            Resa = data.Resa;
            ReservationMode = data.ReservationMode;
            Section = data.Section;
            SectionCode = data.SectionCode;
            Site = data.Site;
            SiteCode = data.SiteCode;
            SourceType = data.SourceType;
            Statut = data.Statut;
            TopLevelScope = data.TopLevelScope;
            TopLevelScopeCode = data.TopLevelScopeCode;
            Type = data.Type;
            WhenBack = data.WhenBack;
            IsSelected = true;
        }

        public object AlternativeCote { get; set; }
        public string Barcode { get; set; }
        public string BaseName { get; set; }
        public string BookingTooltip { get; set; }
        public string BookingTooltipCode { get; set; }
        public object Category { get; set; }
        public string Cote { get; set; }
        public string HoldingId { get; set; }
        public string HoldingPlace { get; set; }
        public bool IncludedInSubscription { get; set; }
        public string InfoTooltip { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsExpo { get; set; }
        public bool IsLoanable { get; set; }
        public bool IsReservable { get; set; }
        public bool IsSerial { get; set; }
        public bool IsTransmissible { get; set; }
        public object LibFas { get; set; }
        public string Localisation { get; set; }
        public int NbResa { get; set; }
        public bool NewItem { get; set; }
        public List<object> Other { get; set; }
        public string Place { get; set; }
        public string RecordId { get; set; }
        public string Resa { get; set; }
        public int ReservationMode { get; set; }
        public string Section { get; set; }
        public string SectionCode { get; set; }
        public string Site { get; set; }
        public string SiteCode { get; set; }
        public int SourceType { get; set; }
        public string Statut { get; set; }
        public string TopLevelScope { get; set; }
        public string TopLevelScopeCode { get; set; }
        public string Type { get; set; }
        public string WhenBack { get; set; }
        public bool IsSelected { get; set; }
    }

    public class PlaceReservationOptions
    {
        public HoldingItem HoldingItem { get; set; }
    }
}

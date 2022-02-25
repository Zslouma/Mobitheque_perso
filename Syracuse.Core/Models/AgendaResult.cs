using System;
using System.Collections.Generic;
using System.Text;

namespace Syracuse.Mobitheque.Core.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AgendaAgenda
    {
        public bool CanCreateCategory { get; set; }
        public bool CanCreateEvent { get; set; }
        public bool CanCreateLocation { get; set; }
        public bool CanCreateQueue { get; set; }
        public bool CanDelete { get; set; }
        public bool CanDeleteEvent { get; set; }
        public bool CanDeleteQueue { get; set; }
        public bool CanEdit { get; set; }
        public bool CanEditEvent { get; set; }
        public string Code { get; set; }
        public int Culture { get; set; }
        public string Display { get; set; }
        public bool HasAccessRights { get; set; }
        public int IdAgenda { get; set; }
        public string Rights { get; set; }
        public int Site { get; set; }
    }

    public class AgendaCategorie
    {
        public int AgendaAgendaId { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public string Color { get; set; }
        public int Culture { get; set; }
        public string IconPath { get; set; }
        public int IdCategorie { get; set; }
        public string Libelle { get; set; }
        public int Site { get; set; }
        public string TextColor { get; set; }
        public object Theme { get; set; }
    }

    public class AgendaLocalisation
    {
        public string AdditionalField1 { get; set; }
        public string AdditionalField2 { get; set; }
        public string AdditionalField3 { get; set; }
        public int AgendaAgendaId { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public int Culture { get; set; }
        public int IdLocalisation { get; set; }
        public string Libelle { get; set; }
        public int Site { get; set; }
    }

    public class AgendaInscription
    {
        public int AgendaAgendaId { get; set; }
        public int AgendaEvenementId { get; set; }
        public string AgendaEvenementTitle { get; set; }
        public int AgendaFileIdFile { get; set; }
        public int AgendaFileSize { get; set; }
        public int AgendaFileSizeLeft { get; set; }
        public string AgendaPlageDisplayDate { get; set; }
        public int AgendaPlageIdPlage { get; set; }
        public int AgendaUserId { get; set; }
        public bool CanRefuse { get; set; }
        public bool CanValidate { get; set; }
        public int Culture { get; set; }
        public DateTime DateInscription { get; set; }
        public string DateInscriptionDisplay { get; set; }
        public object DateValidation { get; set; }
        public int IdInscription { get; set; }
        public object IsMailActivated { get; set; }
        public object MessageAdmin { get; set; }
        public int Nb { get; set; }
        public int Site { get; set; }
        public int Statut { get; set; }
        public string UserLibrary { get; set; }
        public string UserMail { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
    }

    public class AgendaFile
    {
        public int AgendaEvenementId { get; set; }
        public string AgendaEvenementTitle { get; set; }
        public List<AgendaInscription> AgendaInscriptions { get; set; }
        public string AgendaPlageDisplayDate { get; set; }
        public int AgendaPlageIdPlage { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public bool ContainsSubscriptionsWithMail { get; set; }
        public int Culture { get; set; }
        public DateTime DateCloture { get; set; }
        public string DateClotureDisplay { get; set; }
        public object DateOuverture { get; set; }
        public object DateOuvertureDisplay { get; set; }
        public int IdFile { get; set; }
        public object Label { get; set; }
        public bool OverflowAllowed { get; set; }
        public int Site { get; set; }
        public int Size { get; set; }
        public int SizeLeft { get; set; }
        public int SizeLeftWithWaiting { get; set; }
    }

    public class AgendaPlage
    {
        public string AgendaCategorieColor { get; set; }
        public int AgendaCategorieId { get; set; }
        public string AgendaCategorieName { get; set; }
        public string AgendaCategorieTextColor { get; set; }
        public string AgendaEvenementCreatedByDisplayName { get; set; }
        public string AgendaEvenementCreatedById { get; set; }
        public DateTime AgendaEvenementDateModification { get; set; }
        public string AgendaEvenementDisplayDateModification { get; set; }
        public string AgendaEvenementFileImport { get; set; }
        public int AgendaEvenementId { get; set; }
        public string AgendaEvenementModifiedByDisplayName { get; set; }
        public string AgendaEvenementModifiedById { get; set; }
        public int AgendaEvenementStatus { get; set; }
        public string AgendaEvenementTitle { get; set; }
        public List<AgendaFile> AgendaFiles { get; set; }
        public int AgendaLocalisationId { get; set; }
        public string AgendaLocalisationName { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public int Culture { get; set; }
        public string CultureName { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string DisplayDateDebut { get; set; }
        public string DisplayDateFin { get; set; }
        public int IdPlage { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsPassed { get; set; }
        public string Notes { get; set; }
        public int Site { get; set; }
    }

    public class AgendaResult
    {
        public string AdditionalField1 { get; set; }
        public string AdditionalField2 { get; set; }
        public string AdditionalField3 { get; set; }
        public string Adresse { get; set; }
        public AgendaAgenda AgendaAgenda { get; set; }
        public int AgendaAgendaId { get; set; }
        public AgendaCategorie AgendaCategorie { get; set; }
        public int AgendaCategorieId { get; set; }
        public List<object> AgendaDocuments { get; set; }
        public AgendaLocalisation AgendaLocalisation { get; set; }
        public int AgendaLocalisationId { get; set; }
        public List<AgendaPlage> AgendaPlages { get; set; }
        public bool CanCreate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public string Chapeau { get; set; }
        public string Conditions { get; set; }
        public string Contract { get; set; }
        public string CreatedByDisplayName { get; set; }
        public string CreatedById { get; set; }
        public int Culture { get; set; }
        public string CultureCode { get; set; }
        public string CultureName { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public string Description { get; set; }
        public string DisplayDateCreation { get; set; }
        public string DisplayDateModification { get; set; }
        public string FileImport { get; set; }
        public string GpsCoordinates { get; set; }
        public int IdEvenement { get; set; }
        public string ImagePath { get; set; }
        public string ModifiedByDisplayName { get; set; }
        public string ModifiedById { get; set; }
        public object PrettyTitle { get; set; }
        public object Selection { get; set; }
        public int SelectionId { get; set; }
        public object SelectionName { get; set; }
        public int Site { get; set; }
        public string SiteDescription { get; set; }
        public string SiteName { get; set; }
        public string SourceUrl { get; set; }
        public int Statut { get; set; }
        public string Titre { get; set; }
        public string Ville { get; set; }
    }


}

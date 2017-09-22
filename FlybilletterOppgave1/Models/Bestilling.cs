using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlybilletterOppgave1.Models
{
    public class Bestilling
    {
        // dette er både en domenemodell og en view-modell
        public int id { get; set; }
        [Display(Name = "Fra sted")]
        [Required(ErrorMessage = "Fra-sted må oppgis")]
        public string FraSted { get; set; }
        [Display(Name = "Til sted")]
        [Required(ErrorMessage = "Til-sted må oppgis")]
        public string TilSted { get; set; }
        [Display(Name = "")]
        [Required(ErrorMessage = "Adressen må oppgis")]
        public string adresse { get; set; }
        [Display(Name = "Postnr")]
        [Required(ErrorMessage = "Postnr må oppgis")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "Postnr må være 4 siffer")]
        public string postnr { get; set; }
        [Display(Name = "Poststed")]
        [Required(ErrorMessage = "Poststed må oppgis")]
        public string poststed { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Section2_IPG521.Models
{
    public class Papers
    {
        [Key]
        [BindNever]
        public int PaperId { get; set; }

        [Required(ErrorMessage = "Title field is required")]
        [Display(Name = "Paper Title")]
        public string paperTitle { get; set; }

        [Required(ErrorMessage = "Title Abstract is required")]
        [Display(Name = "Paper Abstract")]
        public string PaperAbstract { get; set; }

        public string PaperAuthor { get; set; }

        [Display(Name = "Submission Date")]
        public string PaperDateSubmitted { get; set; }

        [BindNever]
        public int TopicId { get; set; }

    }
}
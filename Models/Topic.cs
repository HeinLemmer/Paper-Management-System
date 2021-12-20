using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Section2_IPG521.Models
{
    public class Topic
    {
        [Key]
        [BindNever]
        public int TopicId { get; set; }

        [Required(ErrorMessage ="Topic Name required")]
        [Display(Name = "Topic Name")]
        public string TopicName { get; set; }
    }
}
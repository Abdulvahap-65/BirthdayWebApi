using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace BirthdayWebApi.Models
{
    public class InvitationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Eposta { get; set; }
        [Required]
        public bool? JoiningCase { get; set; }
    }
}
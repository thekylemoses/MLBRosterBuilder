using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLBRosterBuilder.Models
{
    public class Player
    {
        public int ID { get; set; }
        [Display(Name = "Full Name")]
        [Required]
        [StringLength(30)]
        public string FullName { get; set; }

        [Display(Name = "Position (RF, SP, etc.)")]
        [Required]
        [StringLength(2)]
        public string Position { get; set; }
        [Required]
        [Display(Name = "Hand (R/L/S)")]
        [StringLength(1)]
        public string Hand { get; set; }
        [Required]
        public string Education { get; set; }
    }
}

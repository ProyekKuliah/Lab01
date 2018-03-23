using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab01_151524010_FerdhikaYudira.Models
{
    [Table("Competition")] //nama table
    public class Competition
    {
        // Constructor
        public Competition()
        {
            this.Members = new HashSet<Member>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompetitionId { get; set; }

        [Required]
        [Display(Name = "Competition Name")]
        [StringLength(255)]
        public string Name { get; set; }
        
        [StringLength(255)]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string EndDate { get; set; }

        [StringLength(255)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        // Many to many relationship
        public virtual ICollection<Member> Members { get; set; }
    }
}
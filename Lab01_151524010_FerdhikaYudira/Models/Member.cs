namespace Lab01_151524010_FerdhikaYudira.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")] //nama table

    public partial class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(255)]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        
        public Nullable<int> Height { get; set; }
   
        public Nullable<int> Weight { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [Display(Name = "Telephone")]
        [StringLength(12)]
        public string Phone { get; set; }


        //Foreign key
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
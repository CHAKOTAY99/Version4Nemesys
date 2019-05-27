using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RelationshipID { get; set; }

        [Required]
        public virtual IdentityUser User { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        [Required]
        public int Counter { get; set; }
    }
}

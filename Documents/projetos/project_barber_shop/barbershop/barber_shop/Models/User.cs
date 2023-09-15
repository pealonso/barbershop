﻿using barber_shop.Models.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barber_shop.Models
{
    [Table("USER")]
    public class User : Person
    {
        [Column("profile_id")]
        [JsonIgnore]
        public int ProfileId { get; set; }
        [Display(Name = "Perfil")]
        public Profile Profile { get; set; }
    }
}

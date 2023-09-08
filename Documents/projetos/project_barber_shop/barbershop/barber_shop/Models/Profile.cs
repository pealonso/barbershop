﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace barber_shop.Models
{
    public class Profile
    {
        [JsonIgnore]
        public int Id { get; set; }

        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "O tamanho do {0} deve ser entre {2} e {1}")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        public AccountCategory Category { get; set; }

        public Profile() { }

        public Profile(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}

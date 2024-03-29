﻿using System.ComponentModel.DataAnnotations;


namespace BusinessLogic
{
  
    public class UserDTO
    {


        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters")]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 20 characters")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public int Id { get; set; }
        public DateTime Birthday { get; set; }

        public DateTime UserSince { get; set; }

        public byte[]? ProfilePic { get; set; }

        public string? Bio { get; set; }
        public string? Salt { get; set; }
        public string? HashedPass { get; set; }

    }
}

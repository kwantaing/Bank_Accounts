    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    namespace BankAccount.Models
    {
        public class User
        {
            // auto-implemented properties need to match the columns in your table
            // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
            [Key]
            public int user_id { get; set; }
            // MySQL VARCHAR and TEXT types can be represeted by a string
            [Required(ErrorMessage="Please enter a first name.")]
            [Display(Name="First Name")]
            [MinLength(2,ErrorMessage="First name must be at least 2 characters.")]
            public string FirstName { get; set; }
            [Required(ErrorMessage="Please enter a last name.")]
            [Display(Name="Last Name")]    
            [MinLength(2,ErrorMessage="Last name must be at least 2 characters.")]
            public string LastName { get; set; }
            [Required(ErrorMessage="Please enter an email.")]
            [EmailAddress]
            [Display(Name="Email")]
            public string Email { get; set; }
            [Required(ErrorMessage="Please enter a password.")]
            [MinLength(8,ErrorMessage="Password Must be at least 8 characters.")]
            [Display(Name="Password")]
            public string Password { get; set; }
            // The MySQL DATETIME type can be represented by a DateTime
            [NotMapped]
            [Compare("Password", ErrorMessage="Passwords must match!")]
            [Display(Name="Confirm Password")]
            public string PwConfirm{get;set;}
            public double balance{get;set;} = 0;
            public DateTime CreatedAt {get;set;}
            public DateTime UpdatedAt {get;set;}

            public List<Transaction> UserTransactions {get;set;}
        }
        public class Transaction{
            [Key]
            public int transaction_id{get;set;}
            [Required]
            [DataType(DataType.Currency)]
            public double amount{get;set;}
            [Required]
            public int user_id{get;set;}
            public DateTime createdAt{get;set;}

            //Navigation

            public User AccHolder{get;set;}


        }
    }
    
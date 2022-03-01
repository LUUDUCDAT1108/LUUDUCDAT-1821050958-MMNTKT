using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netcoreMVC.Models{
    [Table("Employees")]
    public class Employee{
        [Key]
        public string? EmployeeID {get; set; }
        [Required]
        public string? EmployeeName {get; set; }
        [MaxLength(30)]

        public string? Address {get; set;}

    }
}
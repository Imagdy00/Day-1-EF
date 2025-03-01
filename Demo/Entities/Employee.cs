using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public  string Name { get; set; }
    //    public int? Age { get; set; }
    //    public double Salary { get; set; }
    //    public string? Email { get; set; }

    //    public DateTime DateOfCreation { get; set; }
    //}

    //[Table("hamada" , Schema = "dbo")]
    //class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }
    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }
    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }
    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string PhoneNumber { get; set; }

    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }

    //    [NotMapped]
    //    public double TotalSalaty { get; set; }
    //    public string Password { get; set; }
    //}



    class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }

        public double Salary { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Hire Date")]
        public DateTime HireDate { get; set; }
        [DisplayName("License Number")]
        public int LicenseNumber { get; set; }
        [DisplayName("Certification Type")]
        public string CertificationType { get; set; }
        [DisplayName("Certification Start Date")]
        public DateTime CertificationStartDate { get; set; }
        [DisplayName("Certification End Date")]
        public DateTime CertificationEndDate { get; set; }
    }
}

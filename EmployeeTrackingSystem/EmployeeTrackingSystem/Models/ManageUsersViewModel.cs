using EmployeeTrackingSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class ManageUsersViewModel
    {
        public ApplicationUser[] Admins { get; set; }

        public ApplicationUser[] Managers { get; set; }

        public ApplicationUser[] Users { get; set; }
    }
}
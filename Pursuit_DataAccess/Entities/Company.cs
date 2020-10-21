using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pursuit_DataAccess.Entities
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Address { get; set; }

    }
}

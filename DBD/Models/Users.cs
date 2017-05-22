using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBD.Models
{
    public class Users
    {
        public int Id { get; }
        public string FirstName { get; set; }
		public string LastName { get; set; }
        public string Address { get; set; }
		public int Phone { get; set; }
		public string Mail { get; set; }
        public virtual List<Users> users { get; set; }
    }
}
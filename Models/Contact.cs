using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ContactsEntityFramework.Models
{
    public class Contact
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

        public string GetFullName()
		{
			return this.FirstName + " " + this.LastName;
		}
	}
}

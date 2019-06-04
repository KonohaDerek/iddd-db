using iddd_db.Interfaces;
using iddd_db.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace iddd_db.Models
{
	public class User :IUser
	{
		public User(string name, string password)
		{
			this.Name = name;
			this.Password = password;
		}

		public string GetIdentity()
		{
			return this.GetHashCode().ToString();
		}

		public bool IsAccess()
		{
			throw new NotImplementedException();
		}

		internal User WithEmail(string email)
		{
			if (!email.ValidEmail()) {
				throw new Exception("Not Vaild Email");
			}
			this.Email = email;
			return this;
		}


		internal User WithFax(string fax)
		{
			if (!fax.ValidFax())
			{
				throw new Exception("Not Vaild Email");
			}
			this.Fax = fax;
			return this;
		}


		internal User WithMobile(string mobile)
		{
			if (!mobile.ValidMobile())
			{
				throw new Exception("Not Vaild Email");
			}
			this.Mobile = mobile;
			return this;
		}


		internal User ChangePassword(string pwd)
		{
		
			this.Password = pwd;
			return this;
		}


		public string Name { get ; set ; }
		public string Password { get; set; }
		public string Email { get ; set; }
		public string Fax { get ; set; }
		public string Mobile { get ; set; }


	}
}

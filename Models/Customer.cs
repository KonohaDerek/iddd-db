using iddd_db.Factory;
using iddd_db.Interfaces;

namespace iddd_db.Models
{
    public class Customer : ICustomer
    {
        public Customer(IUser user)
        {
			this.User = user;
        }

		public virtual IUser User { get; set; }

	}
}

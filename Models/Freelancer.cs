using iddd_db.Interfaces;

namespace iddd_db.Models
{

    public class Freelancer : IFreelancer
    {
        public Freelancer(IUser user)
        {
        }


		public virtual IUser User { get; set; }

		public Project TakeProjectCase(string projectId, IFreelancer freelancer)
		{
			throw new System.NotImplementedException();
		}

		public Project TimeSheetEntered(string projectId, IFreelancer freelancer)
		{
			throw new System.NotImplementedException();
		}
	}
}

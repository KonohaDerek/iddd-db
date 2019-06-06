using iddd_db.Factory;
using iddd_db.Interfaces;

namespace iddd_db.Models
{

    public class Freelancer : IFreelancer
    {
		public Freelancer(IUser user)
		{
			this.User = user;
		}


		public virtual IUser User { get; set; }


		/// <summary>
		/// ���ת̱���
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="freelancer"></param>
		/// <returns></returns>
		public Project TakeProjectCase(string projectId)
		{
			return new ProjectFactory().TakeProjectCase(projectId, this.User);
		}

		/// <summary>
		/// �]�w����
		/// </summary>
		/// <param name="projectId"></param>
		/// <returns></returns>
		public Project TimeSheetEntered(string projectId)
		{
			return  new ProjectFactory().TimeSheetEntered(projectId , this.User);
		}
	}
}

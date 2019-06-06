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

		/// <summary>
		/// 新增案子
		/// </summary>
		/// <param name="name"></param>
		/// <param name="content"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		public Project AddNewProject(string name, string content, decimal price)
		{
			return new ProjectFactory().AddNewProject(this.User,name, content,price );
		}

		/// <summary>
		/// 修改案子
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="name"></param>
		/// <param name="content"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		public Project EditProject(string projectId, string name, string content, decimal price)
		{
			return new ProjectFactory().EditProject(projectId,this.User, name, content, price);
		}

		/// <summary>
		/// 移除案子
		/// </summary>
		/// <param name="projectId"></param>
		/// <returns></returns>
		public Project RemoveProject(string projectId)
		{
			return new ProjectFactory().RemoveProject(projectId, this.User);
		}

		/// <summary>
		/// 結束案子
		/// </summary>
		/// <param name="projectId"></param>
		/// <returns></returns>
		public Project FinishedProject(string projectId)
		{
			return new ProjectFactory().FinishedProject(projectId, this.User);
		}
	}
}

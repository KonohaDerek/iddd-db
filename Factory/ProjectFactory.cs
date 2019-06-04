using iddd_db.Interfaces;
using iddd_db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iddd_db.Factory
{
    public class ProjectFactory : IProjectFactory
    {
		// 專案資料清單
		// 應以Repostory+DataSet實作
		// 這邊偷懶直接使用List
		private List<Project> Projects = new List<Project>();


		Project IProjectFactory.AddNewProject(IUser user, string name, string content, decimal price)
        {
			//資料驗證
            if (string.IsNullOrWhiteSpace(name))
            {

            }

           var proejct =  new Project(user,name, content, price);

			Projects.Add(proejct);

		   return proejct;
        }

        Project IProjectFactory.EditProject(string projectId, IUser user, string name, string content, decimal price)
        {
			//找尋特定專案
			var project = Projects.SingleOrDefault(o => o.GetIdentity() == projectId);

			//檢查資料
			if (project.Customer.User.GetIdentity() != user.GetIdentity())
			{
				throw new Exception("Not Vaild");
			}


			//變更資料




			return project;
		}

        Project IProjectFactory.CloseProject(string projectId, IUser user)
        {
			//找尋特定專案
			var project = Projects.SingleOrDefault(o => o.GetIdentity() == projectId);

			//檢查資料
			if (project.Customer.User.GetIdentity() != user.GetIdentity())
			{
				throw new Exception("Not Vaild");
			}

			//變更資料
			project.Close();

			return project;
		}

		bool IProjectFactory.Billing(string projectId, IUser user)
        {
			//找尋特定專案
			var project = Projects.SingleOrDefault(o => o.GetIdentity() == projectId);

			//檢查資料
			if (project.Customer.User.GetIdentity() != user.GetIdentity())
			{
				throw new Exception("Not Vaild");
			}

			//變更資料
			project.Billing();

			return true;
		}

        Project IProjectFactory.TakeProjectCase(string projectId, IUser user)
        {
			//找尋特定專案
			var project = Projects.SingleOrDefault(o => o.GetIdentity() == projectId);

			//檢查資料
			if (project.Customer.User.GetIdentity() != user.GetIdentity())
			{
				throw new Exception("Not Vaild");
			}

			//變更資料
			project.TakeProjectCase(user);

			return project;
		}

        Project IProjectFactory.TimeSheetEntered(string projectId, IUser user)
        {
			//找尋特定專案
			var project = Projects.SingleOrDefault(o => o.GetIdentity() == projectId);

			//檢查資料
			if (project.Customer.User.GetIdentity() != user.GetIdentity())
			{
				throw new Exception("Not Vaild");
			}

			//變更資料
			project.TimeSheetEntered();

			return project;
		}

        ICustomer IProjectFactory.GetCustomer(string projectId, IUser user)
        {
			//找尋特定專案
			var project = Projects.SingleOrDefault(o => o.GetIdentity() == projectId);

			//檢查資料
			if (project.Freelancer.User.GetIdentity() != user.GetIdentity())
			{
				throw new Exception("Not Vaild");
			}

			return project.Customer;
		}

        IFreelancer IProjectFactory.GetContactFreelancer(string projectId, IUser user)
        {
			//找尋特定專案
			var project = Projects.SingleOrDefault(o => o.GetIdentity() == projectId);

			//檢查資料
			if (project.Customer.User.GetIdentity() != user.GetIdentity())
			{
				throw new Exception("Not Vaild");
			}

			return project.Freelancer;
		}
    }
}

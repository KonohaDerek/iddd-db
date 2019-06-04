using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iddd_db.Interfaces;
using iddd_db.Models;

namespace iddd_db.Factory
{
    public class UserFactory : IUserFactory
    {
		// 使用者資料清單
		// 應以Repostory+DataSet實作
		// 這邊偷懶直接使用List
		private List<User> Users = new List<User>();


        IUser IUserFactory.Register(string name, string password, string email, string fax, string mobile)
        {
			var user = new User(name, password)
							.WithEmail(email)
							.WithFax(fax)
							.WithMobile(mobile);
			Users.Add(user);
			return user;
        }

        void IUserFactory.ChangePassword(string userId ,string password)
        {
			//找尋特定用戶
			var user = Users.SingleOrDefault(o=> o.GetIdentity() == userId);
			//變更密碼
			user.ChangePassword(password);
		}

        void IUserFactory.ChangeContactInformation(string userId, string email, string fax, string mobile)
        {
			//找尋特定用戶
			var user = Users.SingleOrDefault(o => o.GetIdentity() == userId);

			//設定聯絡資訊
			user.WithEmail(email)
				.WithFax(fax)
				.WithMobile(mobile);
		}
    }
}

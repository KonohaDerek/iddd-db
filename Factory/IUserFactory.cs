using iddd_db.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iddd_db.Factory
{
    interface IUserFactory
    {
        /// <summary>
        /// 註冊
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        IUser Register(string name, string password, string email, string fax, string mobile);

        /// <summary>
        /// 更換密碼
        /// </summary>
        /// <param name="password"></param>
        void ChangePassword(string userId, string password);

        /// <summary>
        /// 更換聯絡資訊
        /// </summary>
        void ChangeContactInformation(string userId, string email , string fax,string mobile);
    }
}

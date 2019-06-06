using iddd_db.Interfaces;
using iddd_db.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace iddd_db.Factory
{
    public interface IProjectFactory
    {
        /// <summary>
        /// 新增案子
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        Project AddNewProject(IUser user, string name, string content, decimal price);

        /// <summary>
        /// 編輯案子
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="customer"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        Project EditProject(string projectId, IUser user, string name, string content, decimal price);

        /// <summary>
        /// 關閉案子
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        Project RemoveProject(string projectId, IUser user);

		/// <summary>
		/// 結束案子
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="customer"></param>
		/// <returns></returns>
		Project FinishedProject(string projectId, IUser user);

		/// <summary>
		/// 接案
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="freelancer"></param>
		/// <returns></returns>
		Project TakeProjectCase(string projectId, IUser user);

        /// <summary>
        /// 接案者設定TimeSheet
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="freelancer"></param>
        /// <returns></returns>
        Project TimeSheetEntered(string projectId , IUser user);

        /// <summary>
        /// 取得發案人員資料
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="freelancer"></param>
        /// <returns></returns>
        ICustomer GetCustomer(string projectId, IUser user);

        /// <summary>
        /// 取得接案人員資料
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        IFreelancer GetContactFreelancer(string projectId, IUser user);
    }
}

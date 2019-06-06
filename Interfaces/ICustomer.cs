using iddd_db.Models;

namespace iddd_db.Interfaces
{
    ///
    /// 客戶介面
    ///
    public interface ICustomer
    {
		/// <summary>
		/// 新增案件
		/// </summary>
		/// <param name="name"></param>
		/// <param name="content"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		Project AddNewProject(string name, string content, decimal price);

		/// <summary>
		/// 編輯案件
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="name"></param>
		/// <param name="content"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		Project EditProject(string projectId, string name, string content, decimal price);


		/// <summary>
		/// 刪除
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="name"></param>
		/// <param name="content"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		Project RemoveProject(string projectId);


		/// <summary>
		/// 結案
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="name"></param>
		/// <param name="content"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		Project FinishedProject(string projectId);
	}
}

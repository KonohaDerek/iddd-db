using iddd_db.Models;

namespace iddd_db.Interfaces
{
    ///
    /// 客戶介面
    ///
    public interface ICustomer
    {
        /// <summary>
        /// 新增案子
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        Project AddNewProject(string name, string content, decimal price);
    }
}

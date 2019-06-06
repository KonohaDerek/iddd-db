using iddd_db.Models;

namespace iddd_db.Interfaces
{
    public interface IFreelancer
    {

		/// <summary>
		/// 接案者接案
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="freelancer"></param>
		/// <returns></returns>
		Project TakeProjectCase(string projectId);

		/// <summary>
		/// 接案者設定TimeSheet
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="freelancer"></param>
		/// <returns></returns>
		Project TimeSheetEntered(string projectId);
    }
}
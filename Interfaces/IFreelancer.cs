using iddd_db.Models;

namespace iddd_db.Interfaces
{
    public interface IFreelancer
    {

		/// <summary>
		/// ���ת̱���
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="freelancer"></param>
		/// <returns></returns>
		Project TakeProjectCase(string projectId);

		/// <summary>
		/// ���ת̳]�wTimeSheet
		/// </summary>
		/// <param name="projectId"></param>
		/// <param name="freelancer"></param>
		/// <returns></returns>
		Project TimeSheetEntered(string projectId);
    }
}
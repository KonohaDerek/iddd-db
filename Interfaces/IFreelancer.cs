using iddd_db.Models;

namespace iddd_db.Interfaces
{
    public interface IFreelancer
    {

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="freelancer"></param>
        /// <returns></returns>
        Project TakeProjectCase(string projectId, IFreelancer freelancer);


        /// <summary>
        /// ���ת̳]�wTimeSheet
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="freelancer"></param>
        /// <returns></returns>
        Project SetTimeSheet(string projectId, IFreelancer freelancer);
    }
}
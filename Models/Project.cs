using iddd_db.Enum;
using iddd_db.Interfaces;
using System;

namespace iddd_db.Models
{
    public class Project
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project_name"></param>
        /// <param name="timeSheets"></param>
        /// <param name="customer"></param>
        public Project(IUser user , string project_name , string content , decimal price )
        {
            this.Name = project_name;

            this.Content = content;

            this.Price = price;

            this.Customer = new Customer(user);

        }


		public  Project Update( string project_name, string content, decimal price)
		{
			this.Name = project_name;

			this.Content = content;

			this.Price = price;

			return this;
		}

		internal void TakeProjectCase(IUser user)
		{
			this.Freelancer = new Freelancer(user);
			this.Status = ProjectStaus.Taked;
		}


		internal void Finished()
		{
			this.Status = ProjectStaus.Finished;
		}


		/// <summary>
		/// 取得ID
		/// </summary>
		/// <returns></returns>
		internal string GetIdentity()
		{
			return this.GetHashCode().ToString();
		}


		/// <summary>
		/// 專案名稱
		/// </summary>
		public string Name { get; private set; }


        /// <summary>
        /// 專案內容
        /// </summary>
        public string Content { get; private set; }

	
		/// <summary>
		/// 價格
		/// </summary>
		public decimal Price { get; private set; }


        /// <summary>
        /// 發包者資訊
        /// </summary>
        public virtual Customer Customer{get;private set;}


        /// <summary>
        /// 接案者資訊
        /// </summary>
        public virtual Freelancer Freelancer { get; private set; }

        /// <summary>
        /// 完成時間
        /// </summary>
        public DateTime Timesheets{get;private set;}

		

		/// <summary>
		/// 專案狀態
		/// </summary>
		public ProjectStaus Status { get; private set; }

	

		/// <summary>
		/// 建立時間
		/// </summary>
		public DateTime CreateDt { get; private set; }

		internal void TimeSheetEntered()
		{
			this.Timesheets = DateTime.Now;
		}
	}
}

using iddd_db.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace iddd_db.Service
{
    public static class AuthorizationService
    {
        //客戶權限可用項目
        private static readonly string[] CustomerAccess = new string[]{"View","Post","Bill"};

        //自由接案者權限可用項目
        private static readonly string[] FreelancerAccess = new string[] { "View", "TakeCase", "TimeSheet" };

		//Email驗證規則
		private static readonly string EmailPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
				@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

		/// <summary>
		/// 傳真驗證規則
		/// </summary>
		private static readonly string FaxPattern = @"";


		/// <summary>
		/// 手機驗證規則
		/// </summary>
		private static readonly string MobilePattern = @"";

		public static bool IsAuth(this IUser user , string action )
        {
            if (action == null)
            {
                throw new System.ArgumentNullException(nameof(action));
            }

            return false;
        }

		/// <summary>
		/// 驗證電子郵件
		/// </summary>
		/// <param name="email"></param>
		/// <returns></returns>
		public static bool ValidEmail(this string email)
		{
			return Regex.IsMatch(email, EmailPattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
		}

		/// <summary>
		/// 驗證傳真
		/// </summary>
		/// <param name="fax"></param>
		/// <returns></returns>
		public static bool ValidFax(this string fax)
		{
			return Regex.IsMatch(fax, FaxPattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
		}

		/// <summary>
		/// 驗證手機
		/// </summary>
		/// <param name="mobile"></param>
		/// <returns></returns>
		public static bool ValidMobile(this string mobile)
		{
			return Regex.IsMatch(mobile, MobilePattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Radiator.Core;
using TheNuggetList.Domain.Members;
using TheNuggetList.Data;

namespace TheNuggetList.Website.Infrastucture.Membership
{
	public class AuthenticationService : IAuthenticationService
	{
		private readonly NuggetDbContext _dbContext;
		private readonly HttpContext _httpContext;

		public AuthenticationService(NuggetDbContext dbContext, HttpContext httpContext)
		{
			_dbContext = dbContext;
			_httpContext = httpContext;
		}

		public Member GetLoggedInMember()
		{
			string loggedInUserName = _httpContext.User.Identity.Name;
			long memberId;

			if (long.TryParse(loggedInUserName, out memberId))
				return _dbContext.Members.Find(memberId);

			return null;
		}

		public bool IsLoggedIn()
		{
			return _httpContext.User.Identity.IsAuthenticated;
		}

		public bool LoggedInMemberIsAdmin()
		{
			return _httpContext.User.IsInRole("Admin");
		}

		public void SetLoggedInMember(long memberId)
		{
			FormsAuthentication.SetAuthCookie(memberId.ToString(), false);
		}

		public void Logout()
		{
			FormsAuthentication.SignOut();
		}
	}
}
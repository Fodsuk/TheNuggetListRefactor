using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheNuggetList.Domain.Members;

namespace TheNuggetList.Website.Infrastucture.Membership
{
	public interface IAuthenticationService
	{
		Member GetLoggedInMember();
		bool IsLoggedIn();
		void SetLoggedInMember(long memberId);
		void Logout();
	}
}

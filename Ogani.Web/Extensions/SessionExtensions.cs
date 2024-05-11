using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ogani.Domain.Entities.Session;
using Ogani.Domain.Entities.User;
using Ogani.Domain.Enums.UserRoles;

namespace WebApplication1.Extensions
{
    public static class SessionExtensions
    {
        public static UserDataBaseTable GetUser(this HttpSessionStateBase session)
        {
            return (UserDataBaseTable)session["__User"];
        }

        public static void ClearUser(this HttpSessionStateBase session)
        {
            session.Remove("__User");
        }

        public static void SetUser(this HttpSessionStateBase session, UserDataBaseTable user)
        {
            session["__User"] = user;
        }

        public static bool IsUserLoggedIn(this HttpSessionStateBase session)
        {
            return session.GetUser() != null;
        }

        public static bool UserHasRole(this HttpSessionStateBase session, URole role)
        {
            if (!session.IsUserLoggedIn())
                return false;

            var user = session.GetUser();
            return user.Level >= role;
        }
    }
}
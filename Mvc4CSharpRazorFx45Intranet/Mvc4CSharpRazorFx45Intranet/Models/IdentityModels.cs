﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using AspNet.Identity.MySQL;

namespace Mvc4CSharpRazorFx45Intranet.Models
{
    // Sie können Profildaten für den Benutzer durch Hinzufügen weiterer Eigenschaften zur ApplicationUser-Klasse hinzufügen. Weitere Informationen finden Sie unter "http://go.microsoft.com/fwlink/?LinkID=317594".
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Beachten Sie, dass der "authenticationType" mit dem in "CookieAuthenticationOptions.AuthenticationType" definierten Typ übereinstimmen muss.
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Benutzerdefinierte Benutzeransprüche hier hinzufügen
            return userIdentity;
        }
    }

    public class ApplicationDbContext : MySQLDatabase
    {
        public ApplicationDbContext(string connectionName)
            : base(connectionName)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext("DefaultConnection");
        }
    }
}
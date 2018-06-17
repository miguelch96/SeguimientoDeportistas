//using GroupSports.BL.BC;
//using Microsoft.Owin.Security;
//using Microsoft.Owin.Security.OAuth;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using System.Web;

//namespace GroupSportsApiRest.Provider
//{
//    public class OAuthAppProvider : OAuthAuthorizationServerProvider
//    {
//        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
//        {
//            return Task.Factory.StartNew(() =>
//            {
//                LoginDTO loginDTO = new LoginDTO()
//                {
//                    userName = context.UserName,
//                    password = context.Password
//                };

//                var userService = new UserService();
//                user user = userService.Login(loginDTO);
//                if (user != null)
//                {
//                    var claims = new List<Claim>()
//                    {
//                        new Claim(ClaimTypes.Name, user.username),
//                        new Claim("UserID", user.id.ToString())
//                    };
//                    ClaimsIdentity oAutIdentity = new ClaimsIdentity(claims, Startup.OAuthOptions.AuthenticationType);
//                    context.Validated(new AuthenticationTicket(oAutIdentity, new AuthenticationProperties() { }));
//                }
//                else
//                {
//                    context.SetError("invalid_grant", "Error");
//                }
//            });
//        }

//        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
//        {
//            if (context.ClientId == null)
//            {
//                context.Validated();
//            }
//            return Task.FromResult<object>(null);
//        }
//    }
//}
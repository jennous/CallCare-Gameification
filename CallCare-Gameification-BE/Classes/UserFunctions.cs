using CallCare_Gameification_BE.DB;
using CallCare_Gameification_BE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations.Rules;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CallCare_Gameification_BE.Classes
{
    public class UserFunctions
    {
        private readonly callcareDB _context;

        public UserFunctions(callcareDB context)
        {
            _context = context;
        }

        /// <summary>
        /// Checks if user is an admin
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public bool IsAdmin(int userid)
        {
            try
            {
                using (_context)
                {
                    var user = _context.Users.Find(userid);

                    if (user != null)
                    {
                        if (user.IsAdmin == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the user is active/ or not/ deleted
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public ErrorHandleing isActive(int userid)
        {
            try
            {
                using (_context)
                {
                    var user = _context.Users.Find(userid);

                    if (user != null)
                    {
                        if (user.isActive == 1 && user.IsDeleted == 0)
                        {
                            return new ErrorHandleing(HttpStatusCode.OK, "User is active"); ;
                        }
                        else
                        {
                            return new ErrorHandleing(HttpStatusCode.NotFound, "User Not Found"); ;
                        }
                    }
                    else
                    {
                        return new ErrorHandleing(HttpStatusCode.NotFound, "User Not Found"); ;
                    }
                }
            }
            catch (Exception e)
            {
                //this can be improved by also writing the error to a database or other services, that manage issues in services
                return new ErrorHandleing(HttpStatusCode.BadRequest, e.ToString());
            }
        }


        //public ErrorHandleing addPoints(int userid, int adminid, decimal points)
        //{
        //    try
        //    {
        //        using (_context)
        //        {
        //            var user = _context.Users.Find(userid);
        //            var admin = _context.Users.Find(adminid);

        //            if (admin.IsAdmin == 1)
        //            {
        //                //check level
        //                //update user
        //                //update level if needed
        //            }
        //            else
        //            {
        //                return new ErrorHandleing(HttpStatusCode.Unauthorized, "user does not have permission to access this function");
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return new ErrorHandleing(HttpStatusCode.BadRequest, e.ToString());
        //    }
        //}


        public (ErrorHandleing, User) getUser(int userid)
        {
            try
            {
                using (_context)
                {
                    var user = _context.Users.Find(userid);

                    if (user != null)
                    {
                        return (new ErrorHandleing(HttpStatusCode.OK, ""),user);
                    }
                    else
                    {
                        return (new ErrorHandleing(HttpStatusCode.NotFound, "user not found"), null);

                    }

                }
            }
            catch (Exception e)
            {
                return (new ErrorHandleing(HttpStatusCode.BadRequest, e.ToString()),null);
            }
        }

        /// <summary>
        /// returns all user if the user making the request is an admin
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public (ErrorHandleing, DbSet<User>) getUserList(int userid)
        {
            try
            {
                using (_context)
                {
                    var user = _context.Users.Find(userid);
                    

                    if (user != null && user.IsAdmin == 1)
                    {
                        return (new ErrorHandleing(HttpStatusCode.OK, ""), _context.Users);
                    }
                    else
                    {
                        return (new ErrorHandleing(HttpStatusCode.Unauthorized, "user does not have permission to access this function"), null);

                    }
                }
            }
            catch (Exception e)
            {
                return (new ErrorHandleing(HttpStatusCode.Unauthorized, e.ToString()), null);
            }
        }
    }
}

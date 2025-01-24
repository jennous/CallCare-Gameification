using CallCare_Gameification_BE.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Validations.Rules;

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

        public bool isAdmin(int userid)
        {

        }
    }
}

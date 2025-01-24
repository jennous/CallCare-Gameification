using CallCare_Gameification_BE.DB;
using CallCare_Gameification_BE.Models;
using Microsoft.EntityFrameworkCore;

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
        public bool isAdmin(int userid)
        {
            using (var con = new callcareDB())
            {

            }
        }

        public bool isAdmin(int userid)
        {

        }
    }
}

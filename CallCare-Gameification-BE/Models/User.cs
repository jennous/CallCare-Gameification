namespace CallCare_Gameification_BE.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int UserLevel { get; set; }
        public decimal UserPoints { get; set; }
        public int isActive { get; set; }
        public int IsDeleted { get; set; }
        public int IsAdmin { get; set; }
    }
}

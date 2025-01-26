namespace CallCare_Gameification_FE.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int UserLevel { get; set; }
        public decimal UserPoints { get; set; }
        public bool isActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAdmin { get; set; }
    }
}

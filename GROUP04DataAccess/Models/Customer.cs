namespace GROUP04DataAccess.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFullName { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CustomerBirthday { get; set; }
        public byte CustomerStatus { get; set; }
        public string Password { get; set; }
    }
}
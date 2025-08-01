namespace Net7WebApi2Github8.Models
{
    public class Customer
    {
        int Id {get; set;}
      
        string Name {get; set; } = string.Empty;
      
        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;     

        public string MobilePhone { get; set; } = string.Empty;   
        public string HomePhone {get; set;}= string.Empty;

        public int BankAccount {get; set;}
        public string Password {get; set; } = string.Empty;
    }
}

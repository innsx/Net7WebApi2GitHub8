namespace Net7WebApi2Github8.Models
{
    public class Customer
    {
        int Id {get; set;}
      
        string Name {get; set; } = string.Empty;
      
        public string Email { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;


        public string Country { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;


        public string MobilePhone { get; set; } = string.Empty;   
        public string HomePhone {get; set;}= string.Empty;

        public string SSN { get; set; } = string.Empty;

        public string Fax { get; set; } = string.Empty;

    }
}

namespace pim_linfo_csharp
{
    class User
    {
        public string Firstname { get; set; }
        public string Lastname  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Cpf { get; set; }
        public decimal Phone { get; set; }


        public Address[] Addresses;
        public Social Social; 
        public Vehicle[] Vehicles;


        public bool VerifLogin()
        {
            //Esse método irá verificar futuramente a validade do login
            return true;
        }
        public User(string firstname, string lastname, string email, string password, decimal cpf, decimal phone, Address[] addresses, Social social, Vehicle[] vehicles)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Cpf = cpf;
            Phone = phone;
            Addresses = addresses;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Cpf = cpf;
            Phone = phone;
            Social = social;
            Vehicles = vehicles;
        }
    }
}

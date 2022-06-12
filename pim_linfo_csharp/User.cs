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

        public Social Social;
        public Address Address1;
        public Address Address2;
        public Vehicle Vehicle1;
        public Vehicle Vehicle2;

        public User(string firstname, string lastname, string email, string password, decimal cpf, decimal phone, Address address1, Address address2, Social social, Vehicle vehicle1, Vehicle vehicle2)
        {
            Social = new Social();
            Address1 = new Address();
            Address2 = new Address();
            Vehicle1 = new Vehicle();
            Vehicle2 = new Vehicle();

            Vehicle1 = vehicle1;
            Vehicle2 = vehicle2;
            Address1 = address1;
            Address2 = address2;
            Social = social;

            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Cpf = cpf;
            Phone = phone;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Cpf = cpf;
            Phone = phone;
        }
        public void VerifLogin()
        {
            //Esse método irá verificar futuramente a validade do login
        }
    }
}

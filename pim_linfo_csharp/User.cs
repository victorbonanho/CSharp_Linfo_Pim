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


        public void VerifLogin()
        {
            //Esse método irá verificar futuramente a validade do login
        }
        public User(string firstname, string lastname, string email, string password, decimal cpf, decimal phone, Address address1, Address address2, Social social, Vehicle vehicle1, Vehicle vehicle2)
        {
            Social = new Social(
                "email@email.com",
                1199999999,
                "instagram.com",
                "linkedin.com",
                "github.com");
            Address1 = new Address(
                "Rua Fictícia",
                "111",
                "Cãpão",
                "complemento",
                "McDonalds",
                "Valinhos",
                "São Paulo",
                2,
                "Nome da pessoa que pertence o endereço",
                "Email da pessoa que pertence o endereço"
                );
            Address2 = new Address("Rua Fictícia2", 
                "112", 
                "Jardins", 
                "complemento2", 
                "Bobs", 
                "Valinhos", 
                "São Paulo", 
                1, 
                "Nome da pessoa que pertence o endereço", 
                "Email da pessoa que pertence o endereço"
                );
            Vehicle1 = new Vehicle(
                "Nome da pessoa que pertence o carro", 
                "DUG4965", 
                "Subaru", 
                "567876876a", 
                "azul", 
                "emaildono@email.com"
                );
            Vehicle2 = new Vehicle(
                "Nome da pessoa que pertence o carro", 
                "DUG4965", 
                "Subaru", 
                "567876876a", 
                "azul", 
                "emaildono@email.com"
                );

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
    }
}

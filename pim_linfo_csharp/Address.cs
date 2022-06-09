namespace pim_linfo_csharp
{
    class Address
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }
        public string Reference { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string User_email { get; set; }

        public void CompartilharEnd()
        {
            //Este método ao ser acionado fará a lógica de compartilhamento dos dados do endereço.
        }

        public void AtualizarEnd()
        {
            //Este método será acionado quando o usuário atualizar as suas informações de endereço.
        }

        public Address(string street, string number, string neighborhood, string complement, string reference, string city, string state, decimal id, string name, string user_email)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            Complement = complement;
            Reference = reference;
            City = city;
            State = state;
            Id = id;
            Name = name;
            User_email = user_email;
        }
    }
}

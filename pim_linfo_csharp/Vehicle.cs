namespace pim_linfo_csharp
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Plate { get; set; }
        public string Model { get; set; }
        public string Renavam { get; set; }
        public string Color { get; set; }
        public string User_email { get; set; }

        public void armazenarDadosVeiculo()
        {
            //Este método é um CRUD para armazenar os dados de veículos.
        }

        public void validarDados()
        {
            //Este método valida dados dos campos renavam e placa.
        }

        public Vehicle(string name, string plate, string model, string renavam, string color, string user_email)
        {
            Name = name;
            Plate = plate;
            Model = model;
            Renavam = renavam;
            Color = color;
            User_email = user_email;
        }
    }
}

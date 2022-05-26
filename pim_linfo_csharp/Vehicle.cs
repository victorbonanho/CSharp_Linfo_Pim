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

        public void CompartilharVei()
        {
            //Este método ao ser acionado fará a lógica de compartilhamento dos dados do veículo.
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

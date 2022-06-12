namespace pim_linfo_csharp
{
    class Social
    {
        public string User_email { get; set; }
        public decimal Whatsapp { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }

        public Social(string user_email, decimal whatsapp, string instagram, string linkedin, string github)
        {
            User_email = user_email;
            Whatsapp = whatsapp;
            Instagram = instagram;
            Linkedin = linkedin;
            Github = github;
        }

        public void armazenarSocial()
        {
            //Este método é um CRUD para armazenar os dados sociais do usuário
        }
    }
}

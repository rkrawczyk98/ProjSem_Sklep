namespace ProjSem_Sklep_Lib.Models
{
    public class User : BaseModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}

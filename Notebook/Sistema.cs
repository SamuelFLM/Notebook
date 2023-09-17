
namespace Nt.Models
{
    public abstract class Sistema
    {
        public Sistema() { }
        public Sistema(string sistemaOperacional)
        {
            SistemaOperacional = sistemaOperacional;
        }
        protected string SistemaOperacional { get; set; }

        public void InstalarSistemaOperacional()
        {
            Console.WriteLine($"\nInstalando Sistema Operacional : {SistemaOperacional}".ToUpper());
        }

        public void InstalarSoftware(string nomeApp)
        {
            Console.WriteLine($"\nInstalando software: {nomeApp}".ToUpper());
        }
    }
}
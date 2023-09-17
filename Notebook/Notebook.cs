

namespace Nt.Models
{
    public class Notebook : Sistema, INotebook
    {
        public Notebook() { }
        public Notebook(string sistemaOperacional) : base(sistemaOperacional) { }
        public Notebook(string marca, string fabricante, string processador, int memoriaHd, int memoriaRam, string placaDeVideo, decimal preco, string sistemaOperacional) : base(sistemaOperacional)
        {
            Marca = marca;
            Fabricante = fabricante;
            Processador = processador;
            MemoriaHD = memoriaHd;
            MemoriaRam = memoriaRam;
            PlacaDeVideo = placaDeVideo;
            Preco = preco;
        }
        protected string Marca { get; set; }
        protected string Fabricante { get; set; }
        protected string Processador { get; set; }
        protected int MemoriaHD { get; set; }
        protected int MemoriaRam { get; set; }
        protected string PlacaDeVideo { get; set; }
        protected decimal Preco { get; set; }

        public void Desligar()
        {
            Console.WriteLine("Desligando.......");
        }

        public void ExibirConfiguracao()
        {
            Console.WriteLine($"\nMarca: {Marca}".ToUpper());
            Console.WriteLine($"\nFabricante: {Fabricante}".ToUpper());
            Console.WriteLine($"\nProcessador: {Processador}".ToUpper());
            Console.WriteLine($"\nMemoria: {PlacaDeVideo}".ToUpper());
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando.......");
        }
    }
}
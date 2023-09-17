

namespace Nt.Models
{
    public class Notebook : INotebook
    {
        public Notebook() { }
        public Notebook(string marca, string fabricante, string processador, int memoriaHd, int memoriaRam, string placaDeVideo, decimal preco, string sistemaOperacional, int quantidadeAnoGarantia)
        {
            Marca = marca;
            Fabricante = fabricante;
            Processador = processador;
            MemoriaHD = memoriaHd;
            MemoriaRam = memoriaRam;
            PlacaDeVideo = placaDeVideo;
            Preco = preco;
            SistemaOperacional = sistemaOperacional;
            QuantidadeAnoGarantia = quantidadeAnoGarantia;
        }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public string Processador { get; set; }
        public int MemoriaHD { get; set; }
        public int MemoriaRam { get; set; }
        public string PlacaDeVideo { get; set; }
        public decimal Preco { get; set; }
        public string SistemaOperacional { get; set; }
        public int QuantidadeAnoGarantia { get; set; }

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
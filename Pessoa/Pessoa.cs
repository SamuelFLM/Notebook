
namespace P.Models
{
    public abstract class Pessoa : Endereco
    {
        public Pessoa() { }
        public Pessoa(string nome, int idade, int telefone){
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
        }
        public Pessoa(string nome, int idade, int telefone, string rua, int numero, string bairro) : base(rua, numero, bairro)
        {
            Nome = nome;        
            Idade = idade;
            Telefone = telefone;
        }
        protected string Nome { get; set; }
        protected int Idade { get; set; }
        protected int Telefone { get; set; }

    }
}
using C.Models;
using Nt.Models;
using Venda.Models;
using Newtonsoft.Json;

Notebook notebook = new Notebook(
    marca: "ASUS",
    fabricante: "ASUS LTDA",
    processador: "AMD RYZEN 5",
    memoriaHd: 500,
    memoriaRam: 8,
    placaDeVideo: "GTX 1650 4gb",
    preco: 6000,
    sistemaOperacional: "Windows"
);

Vendedor vendedor = new Vendedor(nome: "Ana Clara", idade: 21, telefone: 319800000, 0.10m);
Fornecedor fornecedor = new Fornecedor(empresa: "Amazon", quantidadeAnoGarantia: 2);

Cliente cliente = new Cliente(
    nome: "Samuel",
    idade: 21,
    telefone: 319009980,
    rua: "Dev Senior",
    numero: 888,
    bairro: "Depressao",
    saldo: 7000m,
    formaDePagamento: "PARCELADO"
);


Produto produto = new Produto();

produto.Notebooks.Add(notebook);
produto.Vendedores.Add(vendedor);
produto.Fornecedores.Add(fornecedor);
produto.Clientes.Add(cliente);

string produtoJson = JsonConvert.SerializeObject(produto, Formatting.Indented);

File.WriteAllText("produtos.json", produtoJson);




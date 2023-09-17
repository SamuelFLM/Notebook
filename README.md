<img src="Image/logo.png" alt="logo_samuelflm">


# Abstraindo um celular no Csharp/.NET

<p>
Sou responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que faço uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.
</p>

Criei um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. De acordo com o diagrama abaixo:
</p>

<img src="Image/desafio.png" alt="logo_samuelflm">

## Regras e validações

<p>
A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.<br>
A classe Nokia e Iphone devem ser classes filhas de Smartphone.<br>
O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.
</p>

> Resultado Nokia

<img src="Image/result_nokia.png" alt="logo_samuelflm">

> Resultado Iphone

<img src="Image/result_iphone.png" alt="logo_samuelflm">


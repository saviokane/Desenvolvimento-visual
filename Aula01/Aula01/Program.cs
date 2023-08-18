using Aula01;

Cliente cliente = new();
Console.WriteLine("Informe o cliente: ");
Console.Write("Informe nome: ");
cliente.Nome = Console.ReadLine();
Console.Write("Informe a idade: ");
cliente.Idade = Console.ReadLine();
// Apresentando dados inseridos.
Console.WriteLine("Cliente inserido foi: ");
Console.WriteLine("Nome: " + cliente.Nome);
Console.WriteLine("Nome: " + cliente.Idade);

// Populando a lista com 3 clientes
Console.WriteLine("Inserindo 3 clientes: ");

for (int i = 0; i < 3; i++)
{
    Cliente cTemp = new();
    Console.WriteLine("Infome o nome: ");
    cliente.Nome = Console.ReadLine;
    Console.WriteLine("Infome a idade: ");
    cliente.Idade = Console.ReadLine;
    cTemp.inserir();
}
Console.WriteLine("Clientes inseridos foram: ");
foreach (Cliente cTemp in Cliente.cliente)
{
  Console.WriteLine("Nome: " + cTemp.Nome + "|");
  Console.WriteLine("Idade: "+ cTemp.Idade);  
}

Console.WriteLine("Inserindo um pedido identificado: ");
pedidoidenty pedido = new();
Console.Write("Infome o número do pedido: ");
pedido.Id = Console.ReadLine();
Console.Write("A quem pertence o pedido ?");
String nome = Console.Read();
pedido.Cliente = new(nome);

// Mostrando os resultado

Console.WriteLine("Número do pedido:" + pedido.Id);
Console.WriteLine("Nome do Cliente: " + pedido.Cliente.Nome + " | " + pedido.Cliente.Idade);


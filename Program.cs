using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste no Nokia");
Nokia nokia = new Nokia(numero: "12345", modelo:"teste", imei:"1234", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Candy Crush");

Console.WriteLine("Teste no Iphone");
Iphone iphone = new Iphone(numero: "678", modelo:"teste", imei:"1234", memoria: 6400);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tigrinho");
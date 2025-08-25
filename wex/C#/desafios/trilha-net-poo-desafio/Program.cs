using System.Diagnostics;
using System.Security.Authentication;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Chamando o iphone
Iphone iphone1 = new Iphone(numero: "1234", modelo: "Modelo1", imei: "000000", memoria: 64);
Console.WriteLine("Smartphone Iphone:");
iphone1.ReceberLigacao();
Console.WriteLine("Digite o app que deseja baixar no Iphone:");
iphone1.InstalarAplicativo(Console.ReadLine());

Console.WriteLine("\n");

//Chamando o Nokia
Nokia nokia1 = new Nokia(numero: "1212", modelo: "Modelo2", imei: "111111", memoria: 128);
Console.WriteLine("Smartphone Nokia:");
nokia1.ReceberLigacao();
Console.WriteLine("Digite o app que deseja baixar no Nokia:");
nokia1.InstalarAplicativo(Console.ReadLine());
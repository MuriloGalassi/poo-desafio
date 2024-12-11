using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "5678", modelo: "Modelo 2", imei: "2222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
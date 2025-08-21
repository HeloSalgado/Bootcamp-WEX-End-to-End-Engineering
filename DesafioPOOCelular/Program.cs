using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new("1193232-8738", "Mdei", "8239293", 32);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine("\nSmartphone Iphone");
Iphone iphone = new("1198484-4546", "XS", "7343542", 128);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
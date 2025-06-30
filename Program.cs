using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("1199001122", "Nokia Tijolão", "123456789", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-----------------------------\n");

Console.WriteLine(" Smartphone iPhone:");
Smartphone iphone = new Iphone("1199112233", "iPhone 14", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

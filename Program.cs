using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia...");
Smartphone nokia = new Nokia("13988888888", "Modelo 1", "123456789012345", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Spotify");

Console.WriteLine("\n \n");

Console.WriteLine("Smartphone iPhone...");
Smartphone iphone = new Iphone("13977777777", "Modelo 17", "123456789012344", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Auto Destruição");
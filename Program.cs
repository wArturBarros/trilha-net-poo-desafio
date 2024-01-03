using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia Teste: ");
Smartphone nokia = new Nokia(numero: "9876543", modelo: "nokia1100", imei: "095465433194563", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("zipzop");

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Iphone Teste: ");
Smartphone iphone = new Iphone(numero: "7654321", modelo: "Iphone PlusUltra X", imei: "356303483199848", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokiaTijolao = new Nokia("12345", "3310", "0101010101", 4);
nokiaTijolao.Ligar();
nokiaTijolao.ReceberLigacao();
nokiaTijolao.InstalarAplicativo("MSN Messenger");


Smartphone iphoneMaxPro = new Iphone("67890", "17 Max Pro", "1010101010", 256);
nokiaTijolao.Ligar();
nokiaTijolao.ReceberLigacao();
nokiaTijolao.InstalarAplicativo("iTunes");
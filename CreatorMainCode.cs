using System.Diagnostics;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;



void Generate()
{
    var ozne = new List<string> { "cidebi", "gotveren", "gaykivanc", "anime kizi", "gubes", "askim", "lvbelc5", "illegalcocuk", "tecavuzcu coskun", "ben", "sen", "o", "biz", "siz", "onlar", "ege ve reyyan cifti", "agzina alan", "yusufi", "hitler" };
    var sifat = new List<string> { "güzel", "çıplak", "mutlu", "üzgün", "ağlak", "güçlü", "zor", "kolay", "aşık", "mahzuni", "mazlum", "çift", "tek", "yanlız", "müzkçi", "büyük", "kocaman", "karı", "fenerbahçeli" };
    var nesne = new List<string> { "cidebiyle", "gotverenle", "gaykivancla", "anime kiziyla", "gubesle", "askimla", "lvbelc5le", "illegalcocukla", "tecavuzcu coskunla", "benle", "senle", "onla", "bizle", "sizle", "onlarla", "ege ve reyyan ciftiyle", "yusufiyle", "hitlerle" };
    var fill = new List<string> { "boru teslimatı yaparken", "sevşirken", "yaşlılara yardım ederken", "ölürken", "cities skylines oynarken", "satış yaparken", "fiyat değişikliğine giderken", "marka adı ararken", "marsa giderken", "amerkiaya uçarken", "çay içerken", "ölürken", "gülerken" };
    var sonfill = new List<string> { "düşüyor", "kitap okuyor", "özlüyor", "sigara içiyor", "kaçak meth üretiyor", "seviyor" };
    var rnd = new Random();

    string ozne1 = ozne[rnd.Next(0, ozne.Count)];
    string sifat1 = sifat[rnd.Next(0, sifat.Count)];
    string nesne1 = nesne[rnd.Next(0, nesne.Count)];
    string fiil1 = fill[rnd.Next(0, fill.Count)];

    string c1 = ozne1 + " " + sifat1 + " " + nesne1 + " " + fiil1;

    string ozne2 = ozne[rnd.Next(0, ozne.Count)];
    string sifat2 = sifat[rnd.Next(0, sifat.Count)];
    string nesne2 = nesne[rnd.Next(0, nesne.Count)];
    string fiil2 = fill[rnd.Next(0, fill.Count)];

    string c2 = ozne2 + " " + sifat2 + " " + nesne2 + " " + fiil2;


    string ozne3 = ozne[rnd.Next(0, ozne.Count)];
    string sifat3 = sifat[rnd.Next(0, sifat.Count)];
    string nesne3 = nesne[rnd.Next(0, nesne.Count)];
    string fiil3 = fill[rnd.Next(0, fill.Count)];

    string c3 = ozne3 + " " + sifat3 + " " + nesne3 + " " + fiil3;


    string ozne4 = ozne[rnd.Next(0, ozne.Count)];
    string sifat4 = sifat[rnd.Next(0, sifat.Count)];
    string nesne4 = nesne[rnd.Next(0, nesne.Count)];
    string fiil4 = fill[rnd.Next(0, fill.Count)];
    string sonfiil1 = sonfill[rnd.Next(0, sonfill.Count)];

    string c4 = ozne4 + " " + sifat4 + " " + nesne4 + " " + fiil4 + " " + sonfiil1;

    string p1 = c1 + Environment.NewLine + c2 + Environment.NewLine + c3 + Environment.NewLine + c4;


    string ozne5 = ozne[rnd.Next(0, ozne.Count)];
    string sifat5 = sifat[rnd.Next(0, sifat.Count)];
    string nesne5 = nesne[rnd.Next(0, nesne.Count)];
    string fiil5 = fill[rnd.Next(0, fill.Count)];

    string c5 = ozne5 + " " + sifat5 + " " + nesne5 + " " + fiil5;

    string ozne6 = ozne[rnd.Next(0, ozne.Count)];
    string sifat6 = sifat[rnd.Next(0, sifat.Count)];
    string nesne6 = nesne[rnd.Next(0, nesne.Count)];
    string fiil6 = fill[rnd.Next(0, fill.Count)];

    string c6 = ozne6 + " " + sifat6 + " " + nesne6 + " " + fiil6;


    string ozne7 = ozne[rnd.Next(0, ozne.Count)];
    string sifat7 = sifat[rnd.Next(0, sifat.Count)];
    string nesne7 = nesne[rnd.Next(0, nesne.Count)];
    string fiil7 = fill[rnd.Next(0, fill.Count)];

    string c7 = ozne7 + " " + sifat7 + " " + nesne7 + " " + fiil7;


    string ozne8 = ozne[rnd.Next(0, ozne.Count)];
    string sifat8 = sifat[rnd.Next(0, sifat.Count)];
    string nesne8 = nesne[rnd.Next(0, nesne.Count)];
    string fiil8 = fill[rnd.Next(0, fill.Count)];
    string sonfiil8 = sonfill[rnd.Next(0, sonfill.Count)];

    string c8 = ozne8 + " " + sifat8 + " " + nesne8 + " " + fiil8 + " " + sonfiil8;

    string p2 = c5 + Environment.NewLine + c6 + Environment.NewLine + c7 + Environment.NewLine + c8 + Environment.NewLine;

    string siir = Environment.NewLine+p1 + Environment.NewLine + " " + Environment.NewLine + p2;
    Console.WriteLine(siir);

    Console.Write("Yeni şiir için Y +  Enter, Çıkmak için N + Enter" + Environment.NewLine + Environment.NewLine);
    string yesorno = Console.ReadLine();
    if (yesorno == "Y" || yesorno == "y")
    {
        Generate();
    }
    else if (yesorno == "N" || yesorno == "n")
    {
        Environment.Exit(0);
    }
}

Generate();







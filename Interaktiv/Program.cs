
using System;

Console.WriteLine("ohaa det är en skoldag vill du gå upp och bli redo till skolan eller vill du stanna i sängen");
string svar = Console.ReadLine();
if (svar == "gå upp")
{
    Console.WriteLine("okej bra du valde rätt svar du startar smart");
    Console.ReadLine();
}
else if (svar == "stanna i sängen")
{
    Console.WriteLine("tyvärr bror du har inget vall din mamma kom in och tvinga dig att du ska till skolan");
    Console.ReadLine();    
}
Console.WriteLine("vill du gå till lektionen eller vill du skolka och spela fotboll");
string valde = Console.ReadLine();
if (valde == "gå till lektion")

{
    Console.WriteLine("bra du tänker på studier");
    Console.ReadLine();
}
else if (valde == "skolka")
{
    {
        Console.WriteLine("du får ett samtal av din mamma du blir tvungen att gå till lektionen din idiot ");
        Console.ReadLine();
    }


}
Console.WriteLine("du har prov det finns en jobbig fråga,frågan är vad är 2+1= A:3 B:5 vad väler du");
string välja = Console.ReadLine();
if (välja == "A")
{
    Console.WriteLine("du fick A du går glat hem");
    Console.ReadLine();
}
else if (välja == "B")
{
    {
        Console.WriteLine("du fick F tyvär du går hem ledsen");
        Console.ReadLine();
    }

}
{
    Console.WriteLine("du är på väg hem glad om du fick A:FICK DU A!men du går hem ledsen om du gick hem med F:är du dum fick du F");
    string denhär = Console.ReadLine();
    if (denhär == "fick A")
    {
        Console.WriteLine("bra jobbat trodde du va dum i huvudet");
        Console.ReadLine();
    }
    else if (denhär == "fick F")
    {
        Console.WriteLine("visste du är dum i huvudet du fick uttegångförbud bara för det din dumbo");
        Console.ReadLine();
    }
}
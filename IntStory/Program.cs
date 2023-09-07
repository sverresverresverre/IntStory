Console.WriteLine("Du vaknar upp i ett övergivet mentalsjukhus.");
Console.WriteLine("Du börjar tänka att allt är en dröm, även fast det känns så verkligt!");
Console.WriteLine("Det finns två dörrar i rummet. En är markerad med en 1:a och den andra med en 2:a.");
Console.WriteLine("Går du genom dörr 1 eller dörr 2?");

string door = Console.ReadLine().ToLower();

if (door == "1")
{
    Console.WriteLine("Å nej! En mörk figur rör sig långsamt mot dig.");
    Console.WriteLine("Springer du mot den eller ifrån den?");
    
    string run = Console.ReadLine().ToLower();

    if (run == "mot")
    {
        Console.WriteLine("Figuren springer iväg! Du är alltså så ful att ett monster blir rädd för dig.");
        Console.WriteLine("Nu finns det bara en väg framåt.");
        Console.WriteLine("Den ända vägen ut är att hoppa genom ett fönster längst fram på gången.");
        Console.WriteLine("Hoppar du ut ur fönstret eller inte?");
        Console.WriteLine("Ja eller Nej?");

        string window = Console.ReadLine().ToLower();

        if (window == "ja")
        {
            Console.WriteLine("Fallet tog död på dig.");
        }
        else if (window == "nej")
        {
            Console.WriteLine("Nu bor du här. Gör allt för att överleva. Det finns ingen väg ut");
        }
        else
        {
            Console.WriteLine("Det du har skrivit kan jag inte förstå. Försök igen");
        }
    
    }
    else if (run == "ifrån")
    {
        Console.WriteLine("Figuren hinner ikapp dig eftersom det finns ingen väg ut i stunden.");
        Console.WriteLine("Du dör men det är snabbt och icke smärtsamt.");
    }
    else
    {
        Console.WriteLine("Det du har skrivit kan jag inte förstå. Försök igen");
    }
}
else if (door == "2")
{
    Console.WriteLine("Du finner öppen mark och solsken. Blommorna doftar gott.");
    Console.WriteLine("Problemet är att enda vägarna att fortsätta på är antingen en grotta eller en mörk skog.");
    Console.WriteLine("Går du in i grottan eller mörka skogen?");

    string walk = Console.ReadLine().ToLower();

    if (walk == "grottan")
    {
        Console.WriteLine("Grottan är bäcksvart, men det ligger en ficklampa på marken");
        Console.WriteLine("Plockar du upp den?");
        Console.WriteLine("Ja eller Nej?");

        string flash = Console.ReadLine().ToLower();

        if (flash == "ja")
        {
            Console.WriteLine("Den har inga batterier. Du fastnar i grottan och svälter.");
        }
        else if (flash == "nej")
        {
            Console.WriteLine("Du fastnar i den kolsvarta grottan och svälter.");
        }
        else
        {
            Console.WriteLine("Det du har skrivit kan jag inte förstå. Försök igen");
        }
    }
    else if (walk == "mörka skogen")
    {
        Console.WriteLine("Du hamnar vilse och en stor björn springer mot dig");
        Console.WriteLine("Allting tystnar...");
    }
    else
    {
        Console.WriteLine("Det du har skrivit kan jag inte förstå. Försök igen");
    }
}
else
{
    Console.WriteLine("Det du har skrivit kan jag inte förstå. Försök igen");
}

Console.ReadLine();
using LoginSystemGP;


Console.WriteLine("Har du en bruger?");
Console.WriteLine("Ja[0]     --     Nej[1]");
string svar = Console.ReadLine();
int csvar = Convert.ToInt32(svar);

switch (csvar)
{
    case 0:
        
        Console.Clear();
        new StartUp();
        Console.ReadKey();
 
        break;

    case 1:

        Console.Clear();
        new StartUp.MakeUser();
        break;
}


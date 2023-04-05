using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FordonManager är en klass som hanterar olika typer av fordon, såsom bilar, cyklar och båtar.
            // Run-metod är en metod som startar en meny där användaren kan välja mellan olika alternativ för att skapa, visa eller redigera fordon.
            FordonManager manager = new FordonManager();
            manager.Run();
            
        }
    }
}

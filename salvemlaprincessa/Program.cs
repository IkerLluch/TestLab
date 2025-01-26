namespace salvemlaprincessa;

public class Princessa
{
        public static int[] CountCharacters(string[] armes)
        {
            int llances = 0, cascs = 0, espases = 0, escuts = 0, armadures = 0;

            foreach (var arma in armes)
            {
                if (arma == "Llança") llances++;
                else if (arma == "Casc") cascs++;
                else if (arma == "Espasa") espases++;
                else if (arma == "Escut") escuts++;
                else if (arma == "Armadura") armadures++;
            }

            int cavallers = 0, soldats = 0, pagesos = 0;

            while (cascs > 0 && llances > 0 && armadures > 0 && escuts > 0)
            {
                cavallers++;
                cascs--; llances--; armadures--; escuts--;
            }

            while (cascs > 0 && espases > 0 && escuts > 0)
            {
                soldats++;
                cascs--; espases--; escuts--;
            }

            while (llances > 0)
            {
                pagesos++;
                llances--;
            }

            return new int[] { cavallers, soldats, pagesos };
        }

        static void Main(string[] args)
        {
            string[] armes =
            {
                "Escut", "Casc", "Espasa", "Escut", "Espasa", "Casc", "Armadura", "Llança", "Escut", "Escut", "Casc", "Armadura",
                "Escut", "Llança", "Espasa", "Escut", "Llança", "Escut", "Espasa", "Casc", "Casc", "Escut", "Espasa", "Llança",
                "Llança", "Espasa", "Armadura", "Escut", "Escut", "Armadura", "Armadura", "Llança", "Armadura", "Espasa", "Escut",
                "Casc", "Escut", "Espasa", "Armadura", "Armadura", "Casc", "Casc", "Llança", "Casc", "Escut", "Escut", "Llança",
                "Llança", "Casc", "Espasa", "Armadura", "Casc", "Armadura", "Espasa", "Llança", "Casc", "Llança", "Llança",
                "Espasa", "Casc", "Espasa", "Casc", "Armadura", "Casc", "Casc", "Armadura", "Llança", "Escut", "Escut", "Armadura",
                "Llança", "Espasa", "Casc", "Llança", "Armadura", "Espasa", "Casc", "Escut", "Armadura", "Llança", "Llança", "Casc",
                "Casc", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Armadura", "Espasa", "Espasa", "Armadura", "Escut",
                "Armadura", "Espasa", "Casc", "Llança", "Armadura", "Casc", "Armadura", "Llança", "Casc", "Escut", "Espasa", "Casc",
                "Casc", "Llança", "Llança", "Armadura", "Casc", "Llança", "Llança", "Espasa", "Llança", "Armadura", "Casc", "Casc",
                "Escut", "Casc", "Llança", "Casc", "Escut", "Llança", "Escut", "Espasa", "Escut", "Llança", "Armadura", "Casc",
                "Escut", "Espasa", "Llança", "Llança", "Casc", "Escut", "Casc", "Espasa", "Escut", "Escut", "Llança", "Llança",
                "Llança", "Llança", "Casc", "Escut", "Armadura", "Llança", "Casc", "Espasa", "Espasa",
            };

            var result = CountCharacters(armes);
            Console.WriteLine(result[0] + " " + result[1] + " " + result[2]);
        }
    }




using System.Linq;

namespace Eloi.HelloWorld
{
    public class HelloQwertyCode {


        public static void HelloWowAndQwerty(string[] args)
        {



            //   Bonjour,ceci est un commentaire, un code non execute
            /*
                 Ceci est un commentaire  sur plusieur lignes ;)
                 Et Oui (v) (;..;) (v)             
             */

            /* 
             * J ai remarque que durant les annees precedents les etudiants ne savaient pas dactylographier.
             * Comm je me vois dans l obligation de reapprendre moi aussi a dactylographier en QWERTY,
             * Je propose cette exercice pour decouvrir les bases du C# et de la programmation.
             * Mon but reste de vous apprendre a coder en jouant a des jeux videos, ici World of Warcraft.
             * 
             * Alors sans plus de chi chi, c est parti.
             */

            // Sur une clavier QWERTY nous avons.

            // Les deux premiers character a taper sont F et J

            TypeOnce("F", "J");
            //Position de main https://github.com/EloiStree/HelloSharpForUnity3D/issues/555

            // Vous sentew le petit bout de plastique sur le clavier ?
            // C est la ou vous devez mettre vos doights.

            // Si vous etes sur un QWERTY hors les lettres tout les characters que vous pouvez ecrire sont
            string allSpecialCharacters = "`-=~!@#$%^&*()_+[]{}\\|;:'\",<.>/?";
            TypeOnce(allSpecialCharacters);


            // Essayons d apprendre a programmeter.
            // Tout commencer par une HelloWorld.
            TypeOnce("Hello World !");

            //En C# ca donnerait ceci
            Console.WriteLine("Hello World !");
            TypeOnce("Console.WriteLine(\"Hello World !\");");
            // Constater aue \" permet d echaper un charceter qui nous poserait probleme dans ce text.


            // Console ca referta une boite a outil
            // `.` C est pour dire, va chercher dedans
            // `WriteLine` c est une fonction qui va ecrire une ligne de texte donner
            // `(` et `)` c est le delimitation de ce que on veut donner a la methode WriteLine
            // `;` c est pour dire que la ligne de code est fini et peut s executer.

            TypeOnce('.', '(', ')', ';');


            // Trions dans l ordre d apparition du cours;
            TypeFullText(';');  // Il represente la fin d une ligne de code
            TypeFullText('.');  // Permet d appeler une methode ou une variable dans un object
            TypeFullText("\"String\""); // Permet de declarer un text
            TypeFullText("'c'"); // Permet de declarer un charactere
            TypeFullText('=');  // Permet d assigner une valeur a une variable
            TypeFullText('(');  // commencer a demander des parametres a une methode
            TypeFullText(')');  // Fin de la demande de parametre
            TypeFullText('{');  // Commencer un bloc de code
            TypeFullText('}');  // Fin d un bloc de code
            TypeFullText(',');  // Separateur de parametre entre les ( ,,, )
            TypeFullText("=="); // Demander si deux variables sont egales
            TypeFullText("!");  // Permet de reclamer l inverse d une condition
            TypeFullText("!="); // Demander si deux variables sont differentes
            TypeFullText("<");  // Demander si une variable est plus petite qu une autre
            TypeFullText(">");  // Demander si une variable est plus grande qu une autre
            TypeFullText("<="); // Demander si une variable est plus petite ou egale a une autre
            TypeFullText(">="); // Demander si une variable est plus grande ou egale a une autre
            TypeFullText("&&"); // Demander si deux conditions sont vraies
            TypeFullText("||"); // Demander si une des deux conditions est vraie
            TypeFullText("_"); // Permet de faire du snake_case
            TypeFullText("snake_case"); // Pour le fun
            TypeFullText("-"); // Permet de soustraire une valeur
            TypeFullText("+"); // Permet d additionner une valeur
            TypeFullText("*"); // Permet de multiplier une valeur
            TypeFullText("/"); // Permet de diviser une valeur
            TypeFullText("%"); // Permet de faire le reste d une division
            TypeFullText("\\"); // Permet de mettre des caracteres speciaux dans une chaine de caractere
            TypeFullText('[');  // Ouvrir l index d un tableau
            TypeFullText(']');  // Fermer l index d un tableau
            TypeFullText(":"); // Permet de faire un heritage de classe
            TypeFullText("@"); // Permet de faire une chaine de caractere multi ligne
            TypeFullText("$"); // Permet de faire un rapide string.format avec {} 
            TypeFullText("^"); // Permet de faire une puissance et des operations sur des 1 et 0
            TypeFullText("~"); // Un cas un peu special car il fait des operations sur des 1 et 0
            TypeFullText("`"); // En C# ` est un caractere qui n est pas utiliser mais est utiliser en markdown ```

            // List de tout les characters speciaux avec des demos
            // https://github.com/EloiStree/HelloSharpForUnity3D/issues/557

            //https://monkeytype.com





            // L alphabet minuscule 
            string alphabetMinuscule = "abcdefghijklmnopqrstuvwxyz";
            // L alphabet majuscule
            string alphabetMajuscule = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // Nous avons les chiffres
            string chiffres = "0123456789";

            // C est un ensemble que l on nomme l alphanumerique.
            string alphaNumeric = alphabetMinuscule + alphabetMajuscule + chiffres;

            // Tout ce que vous ecrivez majoritairement doit etre en AlphNumeric avec un exception pour le underscore _
            string underscore = "_";




            List<string> painfullTraining = new List<string>();



            painfullTraining.Add(chiffres);
            painfullTraining.Add(underscore);
            painfullTraining.Add(alphabetMinuscule);
            painfullTraining.Add(alphabetMajuscule);
            painfullTraining.Add(allSpecialCharacters);





            Console.WriteLine($"Bed rock, vous avez fini l exercice. Entrainez vous librement.");
           
            int count = 0;
            while (true)
            {
                if (painfullTraining.Count == 0)
                {
                    Console.WriteLine("Nothing to train on.");
                    break;
                }
                Console.WriteLine($"Nombre de boucles fait " + count);
                TrainOnStringOrderThenShuffle(string.Join("",painfullTraining), 1);
                count++;
            }
        }



        public static void TypeFullText(char text)
        {
            TypeFullText(text.ToString());
        }


        public static void TypeFullText(string text)
        {
            while (true) {
                Console.WriteLine($"Tapez le texte suivant: {text}");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    continue;
                }
                if (input == "asdf" || input == "skip")
                {
                    return;
                }
                else if (input.Length == text.Length && input == text)
                {
                    Console.WriteLine($"Bravo ! Vous avez taper le texte {input}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Non, ce n est pas le bon texte. Essayez encore.");
                }
            }

        }



        public static void TypeOnce (params char[] list )
        {
            TypeOnce(string.Join("", list));
        }


        public static void TypeOnce (List<char> toTrainOn)
        {
            string text = "";
            foreach (char c in toTrainOn)
            {
                text += c;
            }
            TypeOnce(text);


        }
        public static void TypeOnce(params string[] texts)
        {
            foreach (string text in texts)
            {
                TrainOnString(text,false,1);
            }
        }


        public static void TrainOnStringOrderThenShuffle(string textToTrainOn, int trainingCount)
        {
            TrainOnString(textToTrainOn, false,  trainingCount);
            TrainOnString(textToTrainOn, true, trainingCount);
        }

        /// <summary>
        /// Ce code vous demande de taper les lettres donnees jusqu les avoir tout faites.
        /// </summary>
        /// <param name="textToTrainOn"></param>
        /// <param name="shuffleIt"></param>
        public static void TrainOnString(string textToTrainOn, bool shuffleIt, int trainingCount)
        {
            for (int y = 0; y < trainingCount; y++)
            {
                if (shuffleIt)
                {
                    // Melanger le texte
                    Random random = new Random();
                    char[] shuffledText = textToTrainOn.ToCharArray();
                    for (int i = shuffledText.Length - 1; i > 0; i--)
                    {
                        int j = random.Next(0, i + 1);
                        char temp = shuffledText[i];
                        shuffledText[i] = shuffledText[j];
                        shuffledText[j] = temp;
                    }
                    textToTrainOn = new string(shuffledText);
                }
                

                List<char> toTrainOn = textToTrainOn.ToList();
                while (toTrainOn.Count > 0)
                {
                    char toType = toTrainOn[0];
                    string reste = string.Join("", toTrainOn.Skip(1));
                    Console.WriteLine($"Tapez le character suivant: {toType} {reste}");
                    string? input = Console.ReadLine();
                    if (input == null)
                    {
                        continue;
                    }

                    if (input=="asdf" || input =="skip")
                    {
                        return;
                    }

                    else if (input.Length == 1 && input[0] == toTrainOn[0])
                    {
                        toTrainOn.RemoveAt(0);
                        Console.WriteLine($"Bravo ! Vous avez taper le character {input[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"Non, ce n est pas le bon character. Essayez encore.");
                    }
                }

            }
            
        }   

    }

}


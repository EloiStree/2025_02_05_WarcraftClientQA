using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClientQA.Ninja;
using ClientQA.TeacherCode.CoordinateWow;
using ClientQA.UtilityCode;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Eloi.IID;
using System.Security.Cryptography;
using System.Net.Sockets;
using ClientQA.Toolboxes;
using ClientQA.LearningExample.Basic;
using ClientQA.LearningExample.Core;
using Eloi.Example.Cours;

namespace ClientQA.TeacherCode
{

    public class TeacherProgram
    {

        /// <summary>
        /// Cela cible tout les champions sur la mahcine local via ScratchToWarcraft:
        /// https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
        /// 
        /// </summary>
        public static ChampionThread allChampions =new ChampionThread("127.0.0.1", 7073, 0);

        // Change the index with your champion index
        public static ChampionThread yourChampion = new ChampionThread("127.0.0.1", 7073, 1);

        // Change the index with the correct index
        public static ChampionThread healer = new ChampionThread("127.0.0.1", 7073, 1);
        public static ChampionThread tank = new ChampionThread("127.0.0.1", 7073, 2);
        public static ChampionThread hunter = new ChampionThread("127.0.0.1", 7073, 3);
        public static ChampionThread mage = new ChampionThread("127.0.0.1", 7073, 4);
        public static ChampionThread demonist = new ChampionThread("127.0.0.1", 7073, 5);


        public static void TeacherMain(params string[] args)
        {
            new ExChamp_Topic_MethodEtParametre().Run(allChampions);
            // C'est quoi une variable primitive ?
            new ExChamp_Keyword_VariablePrimitive().Run(allChampions);

            // C'est quoi un tableau d'entier ?
            new ExChamp_Topic_IntegerArrayAndloop().Run(allChampions);

            // Si l'on peut faire de macro avec des tableau entier ?
            // On peut faire des tableaus avec des textes via des chars ?
            new ExChamp_Topic_MacroOfCharsWithSwitchAndIf().Run(allChampions);

            // StartWith et IndexOf sont très utile pour les macros
            new ExChamp_Topic_StringStartWithAndIndexOf().Run(allChampions);



            // C'est quoi un variable ?
            // - [ ] C'est quoi des variables primitives ?

            // - [ ] Entier: bit, bytes, short, ushort, int, uint, long, ulong ?
            // - [ ] Ajouter une valeur à un variable ?
            // - [ ] Retirer une valeur à une variable ?
            // - [ ] C'est quoi ça '++' ?
            // - [ ] C'est quoi ça '--' ?
            // - [ ] C'est quoi ça '-=' ?
            // - [ ] C'est quoi ça '+=' ?
            // - [ ] Comment on multiplie une valeur ?
            // - [ ] Comment on divise une valeur ?
            // - [ ] C'est quoi ça '*=' ?
            // - [ ] C'est quoi ça '/=' ?
            // - [ ] C'est quoil a priorité des opérateurse et les ( () + () ) ?

            // - [ ] C'est quoi un casting implicite long a = 42 ?
            // - [ ] C'est quoi un casting explicite (int) variable ?


            // - [ ] Nombre à virgule: float, double ?
            // - [ ] C'est quoi un booléan ?  
            // - [ ] C'est quoi ça '==' ?  
            // - [ ] C'est quoi ça '&&' ?  
            // - [ ] C'est quoi ça '||' ?

            // C'est quoi un méthode
            // - [ ] Une méthode sans argument et sans retour ?
            // - [ ] Une méthode avec des arguments sans retour ?
            // - [ ] Une méthode avec des arguments qui retourne une valeur ?
            // - [ ] C'est quoi un paramètre par défault?
            // - [ ] C'est quoi le mot clé params ?
            // - [ ] C'est quoi c'est quoi un/des out ?


            // - C'est quoi un char et un string ?
            // - C'est quoi un string ?
            // - C'est quoi un tableau de char ?
            // - C'est quoi un char: ASCII, UNICODE ?

            // c'est quoi un réference ?
            new ExChamp_Keyword_ref().Run(allChampions);

        }
    }
}

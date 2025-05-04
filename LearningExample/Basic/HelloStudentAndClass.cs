
// Bonjour à vous 🧙‍, si vous êtes ici c'est que vous avez envie d'apprendre à coder ;)
// Vous ne connaissez donc rien de ce que vous lisez ici (^^' )

// Pour commencer, ce que vous lisez ici est un commentaire representer par ce symbole `//`
// Cela permet de communiquer avec votre futur vous et les autres développeurs qui vous suivent.
/*
 * Si vous avez besoin de plus d'espace
 * Vous pouvez utiliser des commentaires multiligne              
 */

// Je suis en train d'apprendre à dactylographier en QWERTY pour coder. 
// Dactylographier, c'est la pratique de taper sans regarder le clavier.
//
// Je vous propose donc de regarder un peu tous les symboles que vous êtes en capacité d'écrire en QWERTY sur un clavier american.
// Pourquoi ? Car l informaitque tourne autour de l'anglais et que c'est la langue de référence pour coder.
// Du fait de son histoire depuis le 1 janvier 1970.


// Commencons par le mot `using` comme il est obligatoire en prenier ligne.
// Il permet de dire :
// "Copie-moi les codes qu'une personne m'a préparé et qui est dans le projet"
// Nous allons donc utiliser System pour afficher et utiliser la console de Windows et d'autres fonctionnalités.
// Cela importe tout le code d'un "namespace", c'est comme un groupe de code lié ensemble.
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;


// A chaque nouveau mots du cours, vous devriez avoir un equivalent sur le GitHub avec deux trois liens et explication.
// Keyword: veut dire qu il y a un mot que vous devez apprendre et pratiauer quand vous avez le temps.

//Keyword: using https://github.com/EloiStree/HelloSharpForUnity3D/issues/281
//Keyword: System https://github.com/EloiStree/HelloSharpForUnity3D/issues/545


// Un peu complexe pour un debutant, mais j y vais ligne par ligne.
// Revenez sur ce le namepace quand vous aurez un peu plus de pratique.
// Un namespace ici en example est code regroupé sous le un drapeau si je puis dire, ici: "Eloi.HelloWorld"
// C'est comme une grosse boîte à outils
namespace Eloi.HelloWorld
{
    // Keyword: namespace  https://github.com/EloiStree/HelloSharpForUnity3D/issues/90

    // Le character `{` est un symbole qui permet de dire que le code qui si est relier ensemble par un context.
    // Ce regroupement de code est est aussi appelé un "scope" ou "portée" en français.
    // Keyword: scope https://github.com/EloiStree/HelloSharpForUnity3D/issues/26
    // Char: `{` https://github.com/EloiStree/HelloSharpForUnity3D/issues/533

    /*
       Dans cette boîte à outils qu'est Eloi.HelloWorld,
       On aimerait faire des petits bouts de code regroupés ensemble sur une thématique.
       C'est ce que l'on appelle des classes.

       Par exemple, on pourrait lister les étudiants. 

       Je vous propose de "Définir" une classe "EtudiantCodingLevel"
       Qui permettra de stocker le niveau de l'étudiant et pourquoi il veut apprendre à coder.
    */


    // Il y a un troisième type de commentaire. Promit c est le dernier.
    // Il permet de créer de la documentation visible dans les editeur et d automatisée les Wiki/Documentation.
    // Les /// <summary> Vous pouvez mettre votre curseur sur la classe dans l'éditeur. Essayez pour voir </summary>

    /// <summary>
    /// Je suis une classe qui stocke le niveau de l'étudiant et pourquoi il veut apprendre à coder
    /// </summary>
    public class EtudiantCodingLevel
    {

        // EtudiantCodingLevel est le nom de la class que nous avons choisit par hazard.
        // Le mot class vient de ce que l'on appelle la programmation orientée objet. POO (OOP en anglais)
        // L idee est de regrouper des bouts de code qui sont liés ensemble.
        // Ici on essaye de faire des petits bouts de code qui definissent ce qu est un etudiant ;)
        // Son nom, son age, son niveau de code, etc...
        // Keyword: class https://github.com/EloiStree/HelloSharpForUnity3D/issues/34
        // Keyword; OOP https://github.com/EloiStree/HelloSharpForUnity3D/issues/232


        // public est un mot qui permet de dire que l'on peut accéder à cette classe depuis l'extérieur du namespace
        // En gros, vous laissew la porte ouvert. En attendant de voir les Get/Set et l heritage je vais tout mettre en public.
        // Keyword: public https://github.com/EloiStree/HelloSharpForUnity3D/issues/378

        // ... Bon KISS 
        // Retour à la classe EtudiantCodingLevel
        // On veut definir ce que c est un etudiant et son niveau de code.
        // Keyword: KISS https://github.com/EloiStree/HelloSharpForUnity3D/issues/551


        // Pour reconnaître l'étudiant, il nous faudrait stocker son nom.
        // Nous allons le stocker dans une "variable" de type "string"
        // Un string, c'est le nom pour dire un bout de texte
        // Une variable, c'est une petite case dans la mémoire de votre ordinateur. 
        // Des un et des zéros qui sont stockés dans votre memoire RAM
        // Keyword: variable https://github.com/EloiStree/HelloSharpForUnity3D/issues/19
        // Keyword: string https://github.com/EloiStree/HelloSharpForUnity3D/issues/73
        // Keyword: RAM https://github.com/EloiStree/HelloSharpForUnity3D/issues/552


        // Definision un zone de la RAM qui devra etre reserver plus tard pour stocker le nom de l'étudiant
        // Elle n est pas encore reserver. Ici on definit que l on aura besoin plus tard de memoire pour stocker le nom de l'étudiant.
        /// <summary>
        /// Je suis une variable qui décrit le nom et prénom de l'étudiant
        /// </summary>
        public string m_name = "";
        // Remarquez que l'on a stocké une valeur par défaut de "" pour représenter une valeur vide par défaut
        // Char: "" https://github.com/EloiStree/HelloSharpForUnity3D/issues/537

        // Notez le `;` il est la pour dire que nous sommes a la fin d une ligne de code.
        // Cette ligne permet de definir une variable.
        // Char:; https://github.com/EloiStree/HelloSharpForUnity3D/issues/534

        // Demandons-lui son âge 😁...
        // Et comme certains ne nous le donneront pas,
        // Mettons la valeur à -1 par défaut.
        // Une valeur sans virgule, c'est ce que l'on appelle un entier (int = integer en anglais)
        // Keyword: int https://github.com/EloiStree/HelloSharpForUnity3D/issues/371
        /// <summary>
        /// L'âge de l'étudiant s'il accepte de nous le donner
        /// </summary>
        public int m_age = -1;

        // Selon la puissance du PC, certains métiers de l'informatique sont compliqués voire impossibles.
        // Demandons au doigt mouillé la puissance des PC de l etudiant.
        // Cela nous permet de voir ce qu est un nombres à virgule.
        // Un nombre à virgule a une petite particularité.
        // Il peut faire une taille maximale de 8 chiffres.
        // Le reste sera perdu dans les limbes 
        // 01234567890123456789.0132456 serait donc stocké ainsi 12345678 * 10 exposant 11  
        // On verra tout ça plus tard dans le cours sur le valeur primitive
        // Keyword: float https://github.com/EloiStree/HelloSharpForUnity3D/issues/368
        // Keyword: primitive variable https://github.com/EloiStree/HelloSharpForUnity3D/issues/416
        /// <summary>
        /// Quelle est la puissance du PC de l'étudiant chez lui, au doigt levé ?
        /// La donnée est en pourcent de 0.0 à 1.0, où 0 est nul et 1 PC Master Race pour la XR et le cinéma
        /// </summary>
        public float m_puissanceDuPcEnPourcent01 = 0.3f;

        // C'est quoi ce `f` 0.3f ?
        // Ignorez-le pour le moment, mais c'est pour dire que c'est un float et non un double.
        // Keyword: Literal Suffix https://github.com/EloiStree/HelloSharpForUnity3D/issues/546
        // On verra ça plus tard avec les types primitifs.
        // Passons ;)

        // Un outil assez pratique en C#, c'est l'énumération (enum).
        // Cela permet de stocker un choix fixe de possibilités.
        // Exemple : Code Level et Travailler dans l'industrie
        // Keyword: enum https://github.com/EloiStree/HelloSharpForUnity3D/issues/55
        // Pour les seniors 🎖️, il y a ce joli joujou [Flags]
        // Keyword: enum flags https://github.com/EloiStree/HelloSharpForUnity3D/issues/209

        // Ici nous donnons un choix de réponse limité qui ne devrait pas changer dans le temps.
        // Si nous ne donnons pas de valeur par défaut, c'est la première valeur qui sera utilisée : "SansReponse"
        public enum OuiNonPeutEtre { SansReponse, Oui, Non, PeutEtre }

        /// <summary>
        /// L'étudiant veut travailler pour un salaire dans le milieu du développement de logiciel.
        /// </summary>
        public OuiNonPeutEtre m_devenirCoderProfessionnel;

        /// <summary>
        /// L'étudiant veut travailler dans l'industrie du jeu vidéo 
        /// </summary>
        public OuiNonPeutEtre m_travaillerDansLeJeuVideo;

        /// <summary>
        /// L'étudiant veut travailler dans le domaine de la réalité virtuelle et/ou augmentée
        /// </summary>
        public OuiNonPeutEtre m_travaillerDansLaXR;

        /// <summary>
        /// L'étudiant veut travailler dans l'automatisation de scripts pour test de jeu vidéo.
        /// </summary>
        public OuiNonPeutEtre m_travaillerCommeTesteur;

        /// <summary>
        /// Le niveau de l'étudiant actuel entre un hello world et "je connais l'industrie"
        /// </summary>
        public Eloi.HelloWorld.EtudiantCodingLevel.CodeLevel m_maitriseDuCode = CodeLevel.Undefined;
        public enum CodeLevel
        {
            PremierFois, // Vous n'avez jamais codé
            Debutant, // vous avez déjà codé avant
            Junior, // vous connaissez le langage assez pour un stage
            Medior, // Vous avez le niveau pour un job
            Senior, // Vous connaissez tous les design patterns
            Undefined // Pas défini
        }

        /// <summary>
        /// Une courte description d'une ligne, max 400 caractères, de la raison de l'étudiant de vouloir apprendre le code.
        /// </summary>
        public string m_raisonDeVouloirCoderEnUneLigne;

        /// <summary>
        /// Un lien vers le GitHub de l'étudiant pour en savoir plus sur ce qu'il code
        /// </summary>
        public string m_gitHubPortfolioURL;

        /// <summary>
        /// Un lien vers le LinkedIn de l'étudiant pour en savoir plus sur ses compétences et sur son passé dans l'IT
        /// </summary>
        public string m_linkedInPageURL;

        // Avant de continuer cet exercice, si vous êtes en présentiel dans un de mes cours,
        // On va faire une pause pour s'assurer que tout le monde a un GitHub, un LinkedIn et un Discord.




        //SKIP: J en parle plus loin dans l exercice
        public EtudiantCodingLevel() { }

        public EtudiantCodingLevel(
            string name,
            string raisonDeVouloirCoderEnUneLigne,
            float puissanceDuPcEnPourcent01=0.1f,
            OuiNonPeutEtre devenirCoderProfessionnel = OuiNonPeutEtre.SansReponse,
            OuiNonPeutEtre travaillerDansLeJeuVideo = OuiNonPeutEtre.SansReponse,
            OuiNonPeutEtre travaillerDansLaXR = OuiNonPeutEtre.SansReponse, 
            OuiNonPeutEtre travaillerCommeTesteur= OuiNonPeutEtre.SansReponse,
            CodeLevel maitriseDuCode = CodeLevel.PremierFois, 
            string gitHubPortfolioURL = "", 
            string linkedInPageURL="",
            int age=-1 
            )
        {
            m_name = name;
            m_age = age;
            m_puissanceDuPcEnPourcent01 = puissanceDuPcEnPourcent01;
            m_devenirCoderProfessionnel = devenirCoderProfessionnel;
            m_travaillerDansLeJeuVideo = travaillerDansLeJeuVideo;
            m_travaillerDansLaXR = travaillerDansLaXR;
            m_travaillerCommeTesteur = travaillerCommeTesteur;
            m_maitriseDuCode = maitriseDuCode;
            m_raisonDeVouloirCoderEnUneLigne = raisonDeVouloirCoderEnUneLigne;
            m_gitHubPortfolioURL = gitHubPortfolioURL;
            m_linkedInPageURL = linkedInPageURL;
        }
    }

    // Ok on est bon, on est chaud comme des patates 🍟.
    // "As an old Earth saying Captain, a phrase of great power and wisdom, a consolation to the soul in times of need..."
    // Allons-y ! 😁 https://www.youtube.com/watch?v=3IlJFNMAJ-k

    public class HelloStudentAndClass
    {
        public static void StartPoint(string[] args)
        {

            // Manifique nous avons definit ce qu est un "etudiant" dans le context du cours
            // Comment on l utilise ?

            // Creons ce que l on appel un instance.
            // Ca veut dire reserver de la memoire dans la RAM pour stocker un object
            // Ici l objet et de type etudiant.

            // Commencons par Bob et moi

            // https://youtu.be/_7JlQ5om_gs?t=2
            EtudiantCodingLevel bob = new EtudiantCodingLevel();
            bob.m_name = "Bob";
            bob.m_puissanceDuPcEnPourcent01 = 0.25f;
            bob.m_travaillerDansLaXR = EtudiantCodingLevel.OuiNonPeutEtre.Oui;
            bob.m_travaillerDansLeJeuVideo = EtudiantCodingLevel.OuiNonPeutEtre.PeutEtre;
            bob.m_devenirCoderProfessionnel = EtudiantCodingLevel.OuiNonPeutEtre.SansReponse;
            bob.m_travaillerCommeTesteur = EtudiantCodingLevel.OuiNonPeutEtre.Non;
            bob.m_age = 30;
            bob.m_raisonDeVouloirCoderEnUneLigne = "Je veux faire un jeu de barde https://youtu.be/otMyO8GHSHc  https://www.youtube.com/watch?v=d6E-s8AGy4w";
            bob.m_gitHubPortfolioURL = "https://github.com/Bob";
            bob.m_linkedInPageURL = "https://www.linkedin.com/in/bob/";

            // Bon on est normalement 12 étudiants dans le cours.
            // Vas nous falloir un peu de place pour stocker tout ça.
            // Creons un liste;

            List<EtudiantCodingLevel> etudiants = new List<EtudiantCodingLevel>();
            etudiants.Add(new EtudiantCodingLevel(
                "Draux Alexis",
                "Je veux apprendre à coder pour créer des applications utiles.",
                0.5f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Debutant,
                "https://github.com/DrauxAlexis",
                "https://www.linkedin.com/in/drauxalexis",
                25
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Hernandez Osuna Jorge",
                "Je veux apprendre à coder pour travailler dans le jeu vidéo.",
                0.7f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Debutant,
                "https://github.com/HernandezJorge",
                "https://www.linkedin.com/in/hernandezjorge",
                28
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Libert Robert",
                "Je veux apprendre à coder pour automatiser des tâches.",
                0.6f,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.CodeLevel.Debutant,
                "https://github.com/LibertRobert",
                "https://www.linkedin.com/in/libertrobert",
                32
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Libert Shawn",
                "Je veux apprendre à coder pour créer des jeux vidéo.",
                0.4f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.PremierFois,
                "https://github.com/LibertShawn",
                "https://www.linkedin.com/in/libertshawn",
                22
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Puffet Maximilien",
                "Je veux apprendre à coder pour travailler dans la XR.",
                0.9f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Medior,
                "https://github.com/PuffetMaximilien",
                "https://www.linkedin.com/in/puffetmaximilien",
                29
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Roland Marvin",
                "Je veux apprendre à coder pour devenir développeur professionnel.",
                0.3f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Junior,
                "https://github.com/RolandMarvin",
                "https://www.linkedin.com/in/rolandmarvin",
                27
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Soupart Nathalie",
                "Je veux apprendre à coder pour automatiser des tests.",
                0.6f,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.CodeLevel.Debutant,
                "https://github.com/SoupartNathalie",
                "https://www.linkedin.com/in/soupartnathalie",
                30
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Varrasse Julien",
                "Je veux apprendre à coder pour créer des outils pour les développeurs.",
                0.7f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Medior,
                "https://github.com/VarrasseJulien",
                "https://www.linkedin.com/in/varrassejulien",
                33
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Verhaegen Sébastien",
                "Je veux apprendre à coder pour travailler dans le cinéma et la XR.",
                0.8f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Senior,
                "https://github.com/VerhaegenSebastien",
                "https://www.linkedin.com/in/verhaegensebastien",
                40
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Clautier Benjamin",
                "Je veux apprendre à coder pour créer des applications mobiles.",
                0.5f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Debutant,
                "https://github.com/ClautierBenjamin",
                "https://www.linkedin.com/in/clautierbenjamin",
                26
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Carlier Pierre-Emmanuel",
                "Je veux apprendre à coder pour travailler dans l'industrie du jeu vidéo.",
                0.6f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Junior,
                "https://github.com/CarlierPierreEmmanuel",
                "https://www.linkedin.com/in/carlierpierreemmanuel",
                31
            ));
            etudiants.Add(new EtudiantCodingLevel(
                "Vissers Vincent",
                "Je veux apprendre à coder pour créer des outils pour la XR.",
                0.9f,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.OuiNonPeutEtre.Oui,
                EtudiantCodingLevel.OuiNonPeutEtre.Non,
                EtudiantCodingLevel.CodeLevel.Medior,
                "https://github.com/VissersVincent",
                "https://www.linkedin.com/in/vissersvincent",
                34
            ));




            foreach (EtudiantCodingLevel etudiant in etudiants)
            {
                Console.WriteLine($"Nom: {etudiant.m_name}");
                Console.WriteLine($"Âge: {etudiant.m_age}");
                Console.WriteLine($"Puissance du PC: {etudiant.m_puissanceDuPcEnPourcent01}");
                Console.WriteLine($"Devenir codeur professionnel: {etudiant.m_devenirCoderProfessionnel}");
                Console.WriteLine($"Travailler dans le jeu vidéo: {etudiant.m_travaillerDansLeJeuVideo}");
                Console.WriteLine($"Travailler dans la XR: {etudiant.m_travaillerDansLaXR}");
                Console.WriteLine($"Travailler comme testeur: {etudiant.m_travaillerCommeTesteur}");
                Console.WriteLine($"Niveau de code: {etudiant.m_maitriseDuCode}");
                Console.WriteLine($"Raison de vouloir coder: {etudiant.m_raisonDeVouloirCoderEnUneLigne}");
                Console.WriteLine($"GitHub: {etudiant.m_gitHubPortfolioURL}");
                Console.WriteLine($"LinkedIn: {etudiant.m_linkedInPageURL}");
                Console.WriteLine();

                string searchTerm = etudiant.m_name;
               
                if (etudiant.m_travaillerDansLaXR != EtudiantCodingLevel.OuiNonPeutEtre.SansReponse)
                {
                    searchTerm += " XR";
                }
                if (etudiant.m_travaillerDansLeJeuVideo != EtudiantCodingLevel.OuiNonPeutEtre.SansReponse)
                {
                    searchTerm += " Jeu vidéo";
                }
                if (etudiant.m_travaillerCommeTesteur != EtudiantCodingLevel.OuiNonPeutEtre.SansReponse)
                {
                    searchTerm += " Testeur";
                }
                OpenOnGoogle(searchTerm);
            }

            foreach (EtudiantCodingLevel etudiant in etudiants)
            {
                if (etudiant.m_gitHubPortfolioURL != "")
                {
                    OpenOnGoogle(etudiant.m_gitHubPortfolioURL);
                }
                if (etudiant.m_linkedInPageURL != "")
                {
                    OpenOnGoogle(etudiant.m_linkedInPageURL);
                }
            }
            // HOMEWORK, non obligatoire, si vous etes en formation presentielle
            // Avoir un image photo d identité sur le LinkedIn
            // Avoir un description non-etudiant ou vide sur LinkedIn
            // Avoir un GitHub avec une page d'accueil









            Console.WriteLine("Hello World");
            // Keyword: Main https://github.com/EloiStree/HelloSharpForUnity3D/issues/197
            // Keyword: Console https://github.com/EloiStree/HelloSharpForUnity3D/issues/455
            // Keyword: WriteLine https://github.com/EloiStree/HelloSharpForUnity3D/issues/456
            // Char: `;` https://github.com/EloiStree/HelloSharpForUnity3D/issues/534
            // Keyword: ReadLine https://github.com/EloiStree/HelloSharpForUnity3D/issues/457
            // Keyword: allocation https://github.com/EloiStree/HelloSharpForUnity3D/issues/553







            // Ce code va empêcher de continuer le programme.
            // Cela vous laisse le temps de lire ce que vous avez écrit
            while (true)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
        }

        public static void OpenOnGoogle(string search)
        {
           OpenUrl($"https://www.google.com/search?q={Uri.EscapeDataString(search)}");
        }
        public static void OpenUrl(string url)
        {

            // Open webpage in google with name in params  
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {

                FileName = "cmd",
                Arguments = $"/c start "+ url,
                CreateNoWindow = true
            });

        }

    }

}


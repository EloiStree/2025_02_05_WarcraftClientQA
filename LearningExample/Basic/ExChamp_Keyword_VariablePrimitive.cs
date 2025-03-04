using ClientQA.LearningExample.Core;

public class ExChamp_Keyword_VariablePrimitive : A_ChampionThreadExample
{
    public override void Run(ChampionThread championToUse)
    {
        // Si vous êtes ici, c'est que vous débuter en programmation.
        // La bienvenue à vous !

        // Ceci est un floatant
        float angle = 45.0f;
        // Il va nous permettre de tourner notre champion
        championToUse.RotationToLeftAngle(angle);

        // Si l'on veut le faire tourner à gauche ou à droite, il nous faudra un booléan
        // C'est une valeur qui peut être vrai ou faux
        bool isTurningLeft = true;
        if (isTurningLeft)
        {
            championToUse.RotationToLeftAngle(angle);
        }
        else
        {
            championToUse.RotationToRightAngle(angle);
        }

        // Les floatants permet d'avoir des chiffre à virgules (ex: 3.14) sur 8 chiffres 
        // Example avec pi (3.1415926)
        float piAsfloat = 3.1415926f;
        // Cela est suffisant pour une rotation.

        // Si vous désirez utiliser plus de précision, vous pouvez utiliser un double
        // Example avec pi (3.14159265358979323846)

        double piAsDouble = 3.14159265358979323846;


        // Essayons de bouger de 2 seconds vers l'avant
        float timeToMoveInSeconds = 2.0f;

        // Pour cela, il nous faudra des milliseconds pour faire attendre le programme
        // Nous allons utiliser ce que l'on appelle un cast explicity d'un float à un entier.
        // Pourquoi ?
        // Car un entier n'a pas de virgule.
        // Il y a une perte, il faut donc préciser à l'ordinateur que l'on est conscient de cette perte.
        int timeToMoveInMilliseconds = (int)(timeToMoveInSeconds * 1000);

        championToUse.StartMovingForward();
        Thread.Sleep(timeToMoveInMilliseconds);
        championToUse.StopMovingForward();



        // Comme un sortilège prendre 1.7-1.9 entre chaque sortilège
        // Je vous ai prépare une méthode.
        championToUse.WaitTwoSeconds();

        //Le jeux sur l'ordinateur tourne à 20 images par secondes (20 FPS)
        // Cela veut dire que une frame dure 50 millisecondes
        int framePerSecond = 20;
        int frame = (int)(1.0 / framePerSecond);
        // Cela nous donne 50 millisecondes

        // Si vous essayer de bouger votre personange trop vite, la touche peu ne pas être détecté
        championToUse.StartJump();
        championToUse.StopJump();

        // Pour éviter cela nous allons attendre le temps d'un frame
        championToUse.StartJump();
        Thread.Sleep(frame);
        championToUse.StopJump();

        // Je vous ai prépare une méthode pour cela
        championToUse.WaitOneFrame();

        // Comme un informaticien est paresseux par nature, nous créon des racourcis.
        // Vous pouvez essayer celui-ci
        championToUse.TapJump();

        // C'est quoi le type primitive du binaire 1 et 0 ?

        // Sur les ordinateurs , il y a pas de 1 et 0 que l'on appelle un bit.
        // Mais on a des groupes de bytes formant 8 bits.

        byte unGroupeDeBit = 0b00000100;
        // En entier cela vaudrait 4
        int unByteEnEntier = unGroupeDeBit;
        // bougons votre personnage de 4 unités en arrière pour voir
        championToUse.MoveForDistance(-unByteEnEntier);

        // C'est quoi la taille maximum d'un bytes ?
        int tailleMinimum = byte.MinValue; // 0
        int tailleMaximum = byte.MaxValue; // 255

        // Ca sert à quoi un byte ?

        // Un example est pour les couleurs
        byte red = 255;
        byte green = 0;
        byte blue = 0;
        byte alpha = 124;
        // Cela permet de faire un couleur rouge à moitier transparentes.


        // Vous pouvez aussi transformer du texte en bytes et des bytes en texte

        char lettre = 'A';
        byte lettreEnByte = (byte)lettre;
        // Cela donne 65
        // Ajoutons y 2 pour voir
        lettreEnByte +=2;
        // Cela donne 67
        // Transformons le en lettre
        lettre = (char)lettreEnByte;
        // Cela donne C

        // Ce que nous avons fait est une conversion explicite un (cast)
        // Plus ici: https://github.com/EloiStree/HelloSharpForUnity3D/issues/76

        // Nous avons un game entier primitive

        byte unByte = 255;
        // Avec des un et des zéros cela donne 1 bytes et donc 8 bits
        // 11111111

        ushort unshort= 65535;
        // Avec des un et des zéros cela donne 2 bytes et donc 16 bits
        // 11111111 11111111

        uint unInt = 4294967295;
        // Avec des un et des zéros cela donne 4 bytes et donc 32 bits
        // 11111111 11111111 11111111 11111111

        ulong unLong = 18446744073709551615;
        // Avec des un et des zéros cela donne 8 bytes et donc 64 bits
        // 11111111 11111111 11111111 11111111 11111111 11111111 11111111 11111111

        // Il s'avère que nous allons souvent faire des maths avec des entiers
        // Il nous faut donc des entiers signés
        // Pour cela nous allons perdre un bit pour le signe
        // Example pour un byte
        sbyte unByteSigne = -128;
        // Avec des un et des zéros cela donne 1 bytes et donc 8 bits
        // (1)1111111
        // Cela nous fait perdre en longeur de moitier

        // Nous avons donc des entiers signés
        short unShortSigne = -32768;
        // Avec des un et des zéros cela donne 2 bytes et donc 16 bits
        // (1)11111111 11111111

        int unIntSigne = -2147483648;
        // Avec des un et des zéros cela donne 4 bytes et donc 32 bits
        // (1)11111111 11111111 11111111 11111111
        long unLongSigne = -9223372036854775808;
        // Avec des un et des zéros cela donne 8 bytes et donc 64 bits
        // (1)1111111 11111111 11111111 11111111 11111111 11111111 11111111 11111111


        // Si vous avez beaucoup beaucoup de golds dans le jeu, il vous faudra un chiffre très grand.

        // Vous pouvez utiliser un ulong
        ulong golds = 18446744073709551615;


        // Il reste un type de primitive en C# que vous pourriez utiliser si vous jouer à un jeu dans l'espace
        // Un ami du double, le decimal
        decimal distance = 1234567890123456789012345678.1234567890123456789012345678m;
        // Bon par coontre, il prend 128 bits, donc il est lourd en mémoire.
        // 11111111 11111111 11111111 11111111
        // 11111111 11111111 11111111 11111111
        // 11111111 11111111 11111111 11111111
        // 11111111 11111111 11111111 11111111

        // Que ce passe t'il si vous versez un piscine dans une un verre d'eau ?

        byte verreDeau = (byte) distance;
        int verreDeauEnInt = (int)distance;
        long verreDeauEnLong = (long)distance;
        float verreDeauEnFloat = (float)distance;
        double verreDeauEnDouble = (double)distance;



        // Je pouurrais continuer à vous parlez de plein de détailes. Mais pour finir, je vais vous parler du Gandhi bug.


        // Si il est passifique sur une échelle de 0 à 255
        byte aggressiviterDeGandhi =3;

        // Et que un bonus le fait passer à -4 d'aggresiviter ?
        aggressiviterDeGandhi -= 4;
        // Nous avons donc un bug de dépacement
        // Gandhi est passer à 251 d'aggresiviter !!!
        // https://github.com/EloiStree/HelloSharpForUnity3D/issues/507


        // Pour finir, voici la valeur minimal et maximal de chaque type de primitive
        
        long byteMin = byte.MinValue;
        long byteMax = byte.MaxValue;
        long sbyteMin = sbyte.MinValue;
        long sbyteMax = sbyte.MaxValue;
        long shortMin = short.MinValue;
        long shortMax = short.MaxValue;
        long ushortMin = ushort.MinValue;
        long ushortMax = ushort.MaxValue;
        long intMin = int.MinValue;
        long intMax = int.MaxValue;
        long uintMin = uint.MinValue;
        long uintMax = uint.MaxValue;
        long longMin = long.MinValue;
        long longMax = long.MaxValue;
        ulong ulongMin = ulong.MinValue;
        ulong ulongMax = ulong.MaxValue;



        /*
        Integral Types:
        byte : 8-bit unsigned integer
        sbyte : 8-bit signed integer
        short : 16-bit signed integer
        ushort : 16-bit unsigned integer
        int : 32-bit signed integer
        uint : 32-bit unsigned integer
        long : 64-bit signed integer
        ulong : 64-bit unsigned integer
        char : 16-bit Unicode character
        Floating-Point Types:

        float : 32-bit floating-point number
        double : 64-bit floating-point number
        Decimal Type:

        decimal : 128-bit precise decimal value for financial and monetary calculations
        Boolean Type:

        bool : Represents a Boolean value, either true or false
        Other Types:

        void : Represents the absence of a type (used mainly as a return type for methods that do not return a value)
         */

    }

    protected override LearnDifficultyLevel ProvideDifficultyLevelhere()
    => LearnDifficultyLevel.Basic;

    protected override string ProvideLearningUrlHere()
    => "https://github.com/EloiStree/HelloSharpForUnity3D/issues/416";
}



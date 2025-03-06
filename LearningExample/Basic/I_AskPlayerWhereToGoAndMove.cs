using ClientQA.TeacherCode.CoordinateWow;
using System.Collections.Generic;
using System.Xml.Linq;

namespace XboxClientQA.LearningExample.Basic
{


    public enum RotationDirection { Left, Right }
    public interface I_AskPlayerWhereToGoAndMove
    {

        /// <summary>
        /// Sauver la vitesse de déplacement du joueur donner (7 par defaut)
        /// </summary>
        /// <param name="moveSpeed"></param>
        void SetPlayerMoveSpeed(float moveSpeed=7f);
        /// <summary>
        /// Sauver la vitesse de rotation du joueur donner (180 par defaut)
        /// <\summary>
        void SetPlayerRotationSpeed(float rotationSpeed=180f);

        /// <summary>
        /// Demander à l'utilisateur l'angle du joueur sur l'écran
        /// </summary>
        /// <param name="playerAngle"></param>
        void Step00_AskWithConsoleThePlayerAngle(out float playerAngle);
        /// <summary>
        /// Demander à l'utilisateur la position de départ
        /// </summary>
        /// <param name="origin"></param>
        void Step01_AskWithConsoleOrigin(out WowWorldPosition origin);
        /// <summary>
        /// Demander à l'utilisateur la position de destination
        /// </summary>
        /// <param name="destination"></param>
        void Step02_AskWithConsoleDestination(out WowWorldPosition destination);

        /// <summary>
        /// Calculer la distance entre deux points sur world of warcraft pour en déduire le temps de déplacement après
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="destination"></param>
        /// <param name="distance"></param>

        void Step04_ComputeTheDistance(in WowWorldPosition origin, in WowWorldPosition destination, out double distance);
        /// <summary>
        /// Calculer le temps de déplacement en millisecondes depuis la distance données
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="timeToRunInMilliseconds"></param>
        void Step05_ComputeTimeToRun(in double distance, out int timeToRunInMilliseconds);

        /// <summary>
        /// Afficher la distance à parcourir pour informer l'utilisateur
        /// </summary>
        /// <param name="distance"></param>
        void Step06_DisplayInComingDistance(in double distance);
        /// <summary>
        /// Afficher le temps de déplacement en millisecondes pour informer l'utilisateur
        /// </summary>
        /// <param name="timeToRunInMilliseconds"></param>
        void Step07_DisplayTimeToRunInMilliseconds(in int timeToRunInMilliseconds);
        /// <summary>
        /// La partie la plus complexe de l'exercice pour un débutant, calculer l'angle de destination
        /// Prenez une feuille de papier pour cette partie là.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="destination"></param>
        /// <param name="angleDestination"></param>
        void Step08_ComputeTheAngleOfDestination(in WowWorldPosition origin, in WowWorldPosition destination, out float angleDestination);
        /// <summary>
        /// Calculer le temps de rotation en millisecondes grâce à la vitesse de rotation du joueur et la direction de l'angle à tourner
        /// </summary>
        /// <param name="angleStart"></param>
        /// <param name="angleDestination"></param>
        /// <param name="rotationDirection"></param>
        /// <param name="millisecondsToRotate"></param>
        void Step09_ComputeRotationTime(in float angleStart,in  float angleDestination, out RotationDirection rotationDirection , out int millisecondsToRotate);


        /// <summary>
        /// Afficher le temps de rotation pour informer l'utilisateur
        /// </summary>
        /// <param name="rotationDirection"></param>
        /// <param name="angleToRotate"></param>
        void Step10_DisplayRotationTime(in RotationDirection rotationDirection, in float angleToRotate);


        /// <summary>
        /// Ok tout est prêt, on peut bouger le champion, utiliser les méthodes de ChampionThread pour bouger le champion.
        /// </summary>
        /// <param name="champion"></param>
        /// <param name="rotation"></param>
        /// <param name="rotationTimeInMilliSeconds"></param>
        /// <param name="moveTimeInMilliseconds"></param>
        void FinalStep_MoveTheChampion(
            in ChampionThread champion,
            in RotationDirection rotation,
            in int rotationTimeInMilliSeconds,
            in int moveTimeInMilliseconds
            );
    }
}

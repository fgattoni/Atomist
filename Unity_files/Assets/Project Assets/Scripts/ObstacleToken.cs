using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Symbolise un jeton d'obstacle. Contient un GameObject, et un lien vers
/// l'obstacle qu'il repr�sente.
/// </summary>
public class ObstacleToken
{
    public Obstacle obstacle { get; private set; } // L'obstacle repr�sent�
    public GameObject obstacleImg { get;  set; } // Le GameObject correspondant
    public int room; // Le num�ro de la salle

    /// <summary>
    /// Constructeur du jeton d'obstacle.
    /// </summary>
    /// <param name="nObstacle">L'obstacle r�f�renc�.</param>
    /// <param name="gameObject">Le gameObject contenant le jeton.</param>
    public ObstacleToken (Obstacle nObstacle, GameObject gameObject)
    {
        obstacle = nObstacle;
        obstacleImg = gameObject;
        room = gameObject.GetComponent<ObstacleScript>().room;
    }

    public void destroy(Player maker) {
        maker.obstacles.Remove(this);
        GameObject.Destroy(obstacleImg);
    }
}
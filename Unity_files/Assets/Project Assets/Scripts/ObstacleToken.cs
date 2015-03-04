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
    public GameObject obstacleImg { get; private set; } // Le GameObject correspondant

    /// <summary>
    /// Constructeur du jeton d'obstacle.
    /// </summary>
    /// <param name="nObstacle">L'obstacle r�f�renc�.</param>
    public ObstacleToken (Obstacle nObstacle)
    {
        obstacle = nObstacle;
        /* Initialisation du GameObject */
        obstacleImg = new GameObject ();
        obstacleImg.name = "Token " + nObstacle.name;
        obstacleImg.AddComponent<Image> ();
        obstacleImg.GetComponent<Image> ().sprite = nObstacle.obstacleResource;

    }
}
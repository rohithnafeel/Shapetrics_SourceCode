using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public enum Shape
    {
        Square,
        Triangle,
        Circle,
        Hexagon
    }

    public Shape obstacleShape;
}
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

    public Sprite squareSprite;
    public Sprite triangleSprite;
    public Sprite circleSprite;
    public Sprite hexagonSprite;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetShape(Shape shape)
    {
        obstacleShape = shape;

        switch (shape)
        {
            case Shape.Square:
                spriteRenderer.sprite = squareSprite;
                break;

            case Shape.Triangle:
                spriteRenderer.sprite = triangleSprite;
                break;

            case Shape.Circle:
                spriteRenderer.sprite = circleSprite;
                break;

            case Shape.Hexagon:
                spriteRenderer.sprite = hexagonSprite;
                break;
        }
    }
}
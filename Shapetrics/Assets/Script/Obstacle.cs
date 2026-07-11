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

    public float speed = 7f;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
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
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public ShapeType obstacleShape;

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

    public void SetShape(ShapeType shape)
    {
        obstacleShape = shape;

        switch (shape)
        {
            case ShapeType.Square:
                spriteRenderer.sprite = squareSprite;
                break;

            case ShapeType.Triangle:
                spriteRenderer.sprite = triangleSprite;
                break;

            case ShapeType.Circle:
                spriteRenderer.sprite = circleSprite;
                break;

            case ShapeType.Hexagon:
                spriteRenderer.sprite = hexagonSprite;
                break;
        }
    }
}
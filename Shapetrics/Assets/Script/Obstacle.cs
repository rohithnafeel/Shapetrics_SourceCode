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
        transform.Translate(
    Vector2.left *
    GameManager.Instance.gameSpeed *
    Time.deltaTime
);

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
                spriteRenderer.color = new Color(0f, 1f, 1f);
                break;

            case ShapeType.Triangle:
                spriteRenderer.sprite = triangleSprite;
                spriteRenderer.color = new Color(1f, 0f, 1f);
                break;

            case ShapeType.Circle:
                spriteRenderer.sprite = circleSprite;
                spriteRenderer.color = new Color(0f, 1f, 0f);
                break;

            case ShapeType.Hexagon:
                spriteRenderer.sprite = hexagonSprite;
                spriteRenderer.color = new Color(0.5f, 0f, 1f);
                break;
        }
    }
}
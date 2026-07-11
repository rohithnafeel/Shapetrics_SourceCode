using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        private void OnTriggerEnter2D(Collider2D other)
    {
        Obstacle obstacle = other.GetComponent<Obstacle>();

        if (obstacle != null)
        {
            if (currentShape == obstacle.obstacleShape)
            {
                Debug.Log("Correct!");
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("Game Over!");
            }
        }
    }
}
}

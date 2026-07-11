using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int bestScore = 0;

    public float distance = 0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI bestScoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Time.timeScale = 1f;

        bestScore = PlayerPrefs.GetInt("BestScore", 0);

        UpdateUI();
    }

    void Update()
    {
        distance += Time.deltaTime * 5f;

        distanceText.text = "Distance: " +
                            Mathf.FloorToInt(distance) +
                            " m";
    }

    public void AddScore()
    {
        score++;

        if (score > bestScore)
        {
            bestScore = score;

            PlayerPrefs.SetInt(
                "BestScore",
                bestScore
            );

            PlayerPrefs.Save();
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;

        bestScoreText.text =
            "Best: " + bestScore;
    }
}
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;

    private void Start()
    {
        RefreshScore();
    }

    public void RefreshScore()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            score.text = PlayerPrefs.GetInt("Score").ToString("N0");
        }
    }
}

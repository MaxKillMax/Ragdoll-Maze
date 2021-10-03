using UnityEngine;
using UnityEngine.UI;

public class ImproveCost : MonoBehaviour
{
    [SerializeField] private Text costText;
    [SerializeField] private Score score;

    public int cost { get; private set; }

    private int upgradeCost = 1;

    private void Start()
    {
        if (ChangeText() == false)
        {
            PlayerPrefs.SetInt("ImproveCost", 1);
            cost = 1;
        }
        else
        {
            cost = PlayerPrefs.GetInt("ImproveCost");
        }
    }

    public void UpgradeAndSpend()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - cost);
        score.RefreshScore();

        PlayerPrefs.SetInt("ImproveCost", PlayerPrefs.GetInt("ImproveCost") + upgradeCost);
        cost += upgradeCost;

        ChangeText();
    }

    private bool ChangeText()
    {
        if (PlayerPrefs.HasKey("ImproveCost"))
        {
            costText.text = PlayerPrefs.GetInt("ImproveCost").ToString("N0");
            return true;
        }
        return false;
    }
}

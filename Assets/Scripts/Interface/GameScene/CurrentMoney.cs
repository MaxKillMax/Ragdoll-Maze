using UnityEngine;
using UnityEngine.UI;

public class CurrentMoney : MonoBehaviour
{
    [SerializeField] private Text moneyText;

    private void Start()
    {
        RefreshMoneyText();
    }

    public void RefreshMoneyText()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            moneyText.text = PlayerPrefs.GetInt("Score").ToString("N0");
        }
    }

}

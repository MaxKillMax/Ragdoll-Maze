using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public bool CollectMoney()
    {
        int currentMoney = 0;
        if (PlayerPrefs.HasKey("Score"))
        {
            currentMoney = PlayerPrefs.GetInt("Score");
        }

        PlayerPrefs.SetInt("Score", currentMoney + 1);

        return true;
    }
}

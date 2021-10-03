using UnityEngine;

public class ImproveNothing : MonoBehaviour
{
    [SerializeField] private ImproveCost improveCost;
    
    public void Upgrade()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            if (PlayerPrefs.GetInt("Score") >= improveCost.cost)
            {
                // This is all upgrade
                Debug.Log("Nothing changed");


                improveCost.UpgradeAndSpend();
            }
        }
    }
}

using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] private CurrentMoney currentMoney;
    [SerializeField] private PlayerScore playerScore;

    private void Start()
    {
        if (playerScore == null)
        {
            Debug.LogError(transform.name + " have null playerScore!");
        }
        if (currentMoney == null)
        {
            Debug.LogError("CurrentMoney is null!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Washer washer))
        {
            if (playerScore.CollectMoney())
            {
                currentMoney.RefreshMoneyText();
                Destroy(gameObject);
            }
        }
    }
}

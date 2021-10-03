using UnityEngine;
using UnityEngine.UI;

public class CurrentSceneUI : MonoBehaviour
{
    [SerializeField] private Text sceneText;

    private void Start()
    {
        sceneText.text = PlayerPrefs.GetInt("Scene").ToString("N0");
    }
}

using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public Text countText;

    public void SetElementCount(int amount)
    {
        countText.text = "Total live objects: " + amount.ToString();
    }
}

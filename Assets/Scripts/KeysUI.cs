using TMPro;
using UnityEngine;

public class KeysUI : MonoBehaviour
{
    private int numkeys = 0;
    public int totalKeys;
    [SerializeField]
    private TextMeshProUGUI text;

    public void IncreaseKeys()
    {
        numkeys++;
        Debug.Log("Keys: " + numkeys);
        text.text = "Keys: " + numkeys + "/" + totalKeys;

    }
}

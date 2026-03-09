    using TMPro;
using UnityEngine;

public class SecretsUI : MonoBehaviour
{
    private int Secrets = 0;
    public int TotalSecrets;
    [SerializeField]
    private TextMeshProUGUI text;

    public void IncreaseSecrets()
    {
        Secrets++;
        Debug.Log("Found Secrets: " + Secrets + "/" + TotalSecrets);
        text.text = "Secrets: " + Secrets + "/" + TotalSecrets;
    }
}

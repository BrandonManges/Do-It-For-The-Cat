using UnityEngine;

public class SecretPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Secret Pickup Triggered");
            FindFirstObjectByType<SecretsUI>().IncreaseSecrets();
            Destroy(gameObject);
        }
    }
}

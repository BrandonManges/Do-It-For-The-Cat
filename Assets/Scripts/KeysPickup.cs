using UnityEngine;

public class KeysPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Key Pickup Triggered");
            FindFirstObjectByType<KeysUI>().IncreaseKeys();
            other.GetComponent<KeyManager>().addKey();
            Destroy(gameObject);
        }
    }
}

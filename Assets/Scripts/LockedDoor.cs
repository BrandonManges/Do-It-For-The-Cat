using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public KeyManager keyManager;

    private void Update()
    {
        if(keyManager.keysCollected >= keyManager.keysNeeded)
        {
            Destroy(gameObject);
        }
    }
}

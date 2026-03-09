using UnityEngine;

public class KeyManager : MonoBehaviour
{
   public int keysCollected = 0;
   public int keysNeeded;

    public void addKey()
    {
        keysCollected++;

        if(keysCollected == keysNeeded)
        {
            Debug.Log("All keys collected!");
        }
    }
}

using System;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    bool triggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package"))
        {
            if (!triggered)
            {
                Debug.Log("Picked up package");
                triggered = true;
            }
        }
        else if (other.CompareTag("Destination"))
        {
            if (triggered)
            {
                Debug.Log("Delivered package to destination");
                triggered = false;
            }
        }
    }
}

using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("why did " + other.gameObject.name + " hit me?");
    }
}

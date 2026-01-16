using UnityEngine;

public class CarCollision : MonoBehaviour
{
    [SerializeField] float slowAmount = 5f;
    Driver driver;
    
    void Start()
    {
        driver = GetComponent<Driver>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            driver.SetSpeed(slowAmount);
        }
    }
}

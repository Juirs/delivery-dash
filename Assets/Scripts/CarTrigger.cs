using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] float boostAmount = 10f;
    
    bool hasPackage;
    ParticleSystem ps;
    Driver driver;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        driver = GetComponent<Driver>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            ps.Play();
        }
        if (other.CompareTag("Destination") && hasPackage)
        {
            Debug.Log("Delivered package to destination");
            hasPackage = false;
            ps.Stop();
        }
        if (other.CompareTag("Boost"))
        {
            driver.SetSpeed(boostAmount);
            Destroy(other.gameObject, destroyDelay);
        }
    }
}
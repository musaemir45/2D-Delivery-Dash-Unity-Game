using UnityEngine;

public class Delivery: MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        // if (the tag is package)
        // then(print picked up package to console)
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }

        if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject,delay);
        }
 
        
    }
}

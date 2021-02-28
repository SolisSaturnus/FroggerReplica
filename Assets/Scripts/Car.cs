
using System.Collections;
using UnityEngine;


public class Car : MonoBehaviour
{
    
    public Rigidbody2D rb;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    float speed = 1f;

    

    void Start()
    {
        
        speed = Random.Range(minSpeed, maxSpeed);

        {
            StartCoroutine(SelfDestruct());
        }
        IEnumerator SelfDestruct()
        {
            yield return new WaitForSeconds(5f);
            Destroy(gameObject);
        }
    }

    void FixedUpdate ()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.deltaTime * speed);
        
    }

   

}

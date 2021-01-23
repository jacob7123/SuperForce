using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade_Explode : MonoBehaviour
{
    public GameObject Smoke;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy_Car" || collision.gameObject.tag == "Enemy_Tank" || collision.gameObject.tag == "Rock")
        {
            Instantiate(Smoke, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject, 0.3f);
        }
        else
        {
            StartCoroutine(Delay_Explode());
        }
    }

    IEnumerator Delay_Explode()
    {
        yield return new WaitForSeconds(5);
        Instantiate(Smoke, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

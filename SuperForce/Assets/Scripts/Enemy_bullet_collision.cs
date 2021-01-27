using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_bullet_collision : MonoBehaviour
{
    public float MoveSpeed = 30;
    public float Destroy_Time = 1.5f;
    public GameObject Smoke;

    public AudioClip Hit_Sound;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destroy_Time);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0 * Time.deltaTime, 0 * Time.deltaTime, MoveSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Smoke, transform.position, transform.rotation);
        if (collision.gameObject.tag == "Player")
        {
            Player_Life.Life_Num--;
            print(Player_Life.Life_Num);
            GetComponent<AudioSource>().PlayOneShot(Hit_Sound);
        }
        Destroy(gameObject, 0.6f);
    }
}

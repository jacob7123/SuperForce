using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enery_inst_Healthpack : MonoBehaviour
{
    public GameObject Healthpack;
    public GameObject Healthpack_Point;
    private int Random_Num;
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
        if (collision.gameObject.tag == "Player_Bullet" || collision.gameObject.tag == "Player_Grenade")
        {
            Random_Num = Random.Range(0, 5);
            //print(Random_Num);
            if(Random_Num <= 1)
                Instantiate(Healthpack, Healthpack_Point.transform.position, Healthpack_Point.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_inst_Gem : MonoBehaviour
{
    public GameObject Gem;
    public GameObject Gem_Point;
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
            if(Random_Num == 0)
                Instantiate(Gem, Gem_Point.transform.position, Gem_Point.transform.rotation);
        }
    }
}

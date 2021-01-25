using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Car_Move_Fire : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody Bullet_Source;
    public GameObject Fire_Point;
    public GameObject Fire_Particle;
    public int Fire_Y = 5;
    public int Fire_Z = 30;
    private float Distance;
    private float i;

    public int Move_Distance_Num = 100;
    public int Fire_Distance_Num = 70;

    public GameObject Tire1;
    public GameObject Tire2;
    public GameObject Tire3;
    public GameObject Tire4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(transform.position, Player.transform.position);
        if(Distance < Move_Distance_Num)
        {
            Tire1.GetComponent<Rotate_Myself>().enabled = true;
            Tire2.GetComponent<Rotate_Myself>().enabled = true;
            Tire3.GetComponent<Rotate_Myself>().enabled = true;
            Tire4.GetComponent<Rotate_Myself>().enabled = true;
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 0.05f);
            transform.LookAt(Player.transform);
            if (Distance < Fire_Distance_Num)
            {
                i += Time.deltaTime;
                if (i > 1)
                {
                    Instantiate(Fire_Particle, Fire_Point.transform.position, Fire_Point.transform.rotation);
                    Rigidbody Bullet = Instantiate(Bullet_Source, Fire_Point.transform.position, Fire_Point.transform.rotation);
                    Bullet.velocity = transform.TransformDirection(new Vector3(0, Fire_Y, Fire_Z));
                    i = 0;
                }
            }
        }
        else
        {
            Tire1.GetComponent<Rotate_Myself>().enabled = false;
            Tire2.GetComponent<Rotate_Myself>().enabled = false;
            Tire3.GetComponent<Rotate_Myself>().enabled = false;
            Tire4.GetComponent<Rotate_Myself>().enabled = false;
        }
    }
}

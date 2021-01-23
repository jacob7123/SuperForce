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
    public int Fire_Z = 50;
    private float Distance;
    private float i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(transform.position, Player.transform.position);
        if(Distance < 100)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 0.05f);
            transform.LookAt(Player.transform);
            if (Distance < 70)
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
    }
}

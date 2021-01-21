using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_bullet_move : MonoBehaviour
{
    public float MoveSpeed = 30;
    public float Destroy_Time = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destroy_Time);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0 * Time.deltaTime, 0 * Time.deltaTime, MoveSpeed * Time.deltaTime);
    }
}

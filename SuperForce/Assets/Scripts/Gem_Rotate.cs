using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem_Rotate : MonoBehaviour
{
    public int Degree = 120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0 * Time.deltaTime, Degree * Time.deltaTime, 0 * Time.deltaTime);
    }
}

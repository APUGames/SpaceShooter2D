using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = health - 1;
        health += 5;
        health *= 4;
        health /= 4;
        
        //Debug.Log(health);
    }
}

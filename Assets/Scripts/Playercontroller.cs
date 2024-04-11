using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Playercontroller : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;

    private void Awake()
    {
        Debug.Log("I'm awoke");
    }

    void Start()
    {
        Debug.Log("I am a player");
        Debug.Log(speed);
        //transform.position = new Vector3(transform.position.x + 300f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //float speed = 100.0f;
        float horizontalDirection = Input.GetAxis("Horizontal");
        float vericalDirection = Input.GetAxis("Vertical");
        transform.Translate(speed * Time.deltaTime * new Vector2(horizontalDirection, vericalDirection));
        //transform.position = new Vector3(transform.position.x + 1.0f, transform.position.y, transform.position.z);
        
        //win condition

    }
}

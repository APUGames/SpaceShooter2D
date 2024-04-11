using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject Laserprefab;
    public Transform rifleTransform;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Quaternion quaternion = Quaternion.Euler(0f, 0f, 0f);
            Instantiate(Laserprefab, rifleTransform.position, quaternion);
        }
    }
}

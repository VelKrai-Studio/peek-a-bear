using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    void Start(){}

    void Update(){}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player Camera")
        {
            Destroy(gameObject);
        }
    }
}
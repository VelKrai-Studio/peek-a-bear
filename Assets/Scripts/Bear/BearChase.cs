using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearChase : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 2;

    void Start(){}

    void Update()
    {
        transform.LookAt(Player);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
}
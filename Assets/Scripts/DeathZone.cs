using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class DeathZone : MonoBehaviour
{
    public MainManager Manager;


    //POLYMORPHISM
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Manager.GameOver();
    }
}

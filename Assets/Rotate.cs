using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //De complrtat in Unity
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;    
    
    void Update()
    {
     //Rotire pe X: 360 gr
     //Time.deltaTime timpul pt frame
     transform.Rotate(360 *speedX*Time.deltaTime, 360 *speedY*Time.deltaTime, 360 *speedZ*Time.deltaTime);    
    }
}

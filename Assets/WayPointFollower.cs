using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{ 
    //Obiectele:punctele: intre care se va misca Platforma
    [SerializeField] GameObject[] wayPoints;
    int currentWayPointIndex = 0;

    //viteza
    [SerializeField] float speed = 1f;

    void Update()
    {
        if(Vector3.Distance(transform.position, wayPoints[currentWayPointIndex].transform.position)< 0.1f){
            currentWayPointIndex++;
            if(currentWayPointIndex>= wayPoints.Length){
                currentWayPointIndex = 0;
            }
        }

        //transform.position = pozitia curenta a platformei
        //wayPoints = pozitiile intre care se va misca
        //speed = cu cat se va muta
        transform.position = Vector3.MoveTowards(transform.position,wayPoints[currentWayPointIndex].transform.position, speed * Time.deltaTime);
    }
}

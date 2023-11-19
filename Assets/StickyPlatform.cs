using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Verificam cand Player-ul atinge platforma
//***Solutia: cu colider***
// Platforma: dreptunghi colider
// Player: capsule colider 
public class StickyPlatform : MonoBehaviour
{
   //Delectam coleziunea dintre Dreptunghi si Capsula

   //Noi avem acest script pentru Platforma, prin urmare, daca Player o atinge ==> Coleziune
   void OnCollisionEnter(Collision collision){
    //"Player"= e numele obiectului
        if(collision.gameObject.name == "Boy"){
            //Player = va lua pozitia Platformei, o vom seta noi
            //argumentul: transform = este platforma
            collision.gameObject.transform.SetParent(transform);
            Debug.Log("Coliziune");

        }
   }

   void OnCollision(Collision collision){
    //"Player"= e numele obiectului
        if(collision.gameObject.name == "Boy"){
            //Player = va lua pozitia Platformei, o vom seta noi
            //argumentul: transform = este platforma
            collision.gameObject.transform.SetParent(transform);

        }
   }

}

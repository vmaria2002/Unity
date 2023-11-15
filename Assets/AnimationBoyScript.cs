using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBoyScript : MonoBehaviour
{
   Animator animator;

    void Start()
    {
        //Ia referinta de la Animator-ul responsabil de Controller
       animator = GetComponent<Animator>();

    }

    void Update()
    {
        //Cand se apasa pe tasta "w", se va activa isWalking =True ==>va porni animatia
        if(Input.GetKey("w")){
            //Se va seta variabila "isWalking"=true;
            animator.SetBool("isWalking", true);
        }
        //Daca nu se apasa "W", sta pe loc, in srarea idle:
        if(!Input.GetKey("w")){
            //Se va seta variabila "isWalking"=true;
            animator.SetBool("isWalking", false);
        }

         if(Input.GetKey("s")){
            //Se va seta variabila "isWalking"=true;
            animator.SetBool("isRunning", true);
        }
        //Daca nu se apasa "W", sta pe loc, in srarea idle:
        if(!Input.GetKey("s")){
            //Se va seta variabila "isWalking"=true;
            animator.SetBool("isRunning", false);
        }
    }
}

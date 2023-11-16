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
        if(Input.GetKey("left")||Input.GetKey("right")||Input.GetKey("up")||Input.GetKey("downdown")){
            //Se va seta variabila "isWalking"=true;
            animator.SetBool("isWalking", true);
            animator.SetBool("isRunning", true);
        }else{
            //Se va seta variabila "isWalking"=true;
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
        }
    }
}

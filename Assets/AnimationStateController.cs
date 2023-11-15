using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    float velocity = 0;
    public float acceleration = 0.1f;
    public float deceleration = 0.5f;

    int VelocityHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        VelocityHash = Animator.StringToHash("Velocity");

    }

    // Update is called once per frame
    //Cand apasam pe "W" creste viteza
    //Cand NU apasam pe "W" scade viteza
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("s");
        //daca se apasa "w", se va creste viteza
        if(forwardPressed && velocity < 1){
            velocity+=Time.deltaTime * acceleration;
        }

        //Daca nu este apasata tasta "w", atunci, viteza scade
        if(!forwardPressed && velocity > 0.01){
            velocity-=Time.deltaTime * acceleration;
        }
        //reset la viteza:
        if(!forwardPressed && velocity < 0.01){
            velocity=0;
        }

        //facem update la velocity!!
        animator.SetFloat(VelocityHash, velocity);
    }


}

// Video2: https://www.youtube.com/watch?v=HmouLR4X47I&list=PLrnPJCHvNZuB5ATsJZLKX3AW4V9XaIV9b&index=2

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb; 

    //Pt a conecta GroundCheck (punctuletul de la baza) cu capsula, face Drag and Drop a obiectului in  Field
    [SerializeField] Transform groundCheck;


    //Layer Mask:  Ground: adaugat la fiecare element:
    [SerializeField] LayerMask ground;

    //Adaugare Audio/Sunete cand face JUMP
    [SerializeField] AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello- yor game was starting");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello- from update function");
        //Jump: Position Y: ++
        /*
        if (Input.GetKeyDown("space")){
            //Preluam: Player- capsula
            //velocity= viteza (x, y, z)
            rb.velocity = new Vector3(0, 5f, 0);
        }
        */

        //Jump doar daca suntem pe Ground, in aer nu va merge
        if(Input.GetButtonDown("Jump")){
            rb.velocity = new Vector3(rb.velocity.x, 5, rb.velocity.z);
            jumpSound.Play();
        }

        //back: Z++
        if(Input.GetKey("right")){
             rb.velocity = new Vector3(0, 0, 2);
        }
        //Forward: Z--
        if(Input.GetKey("left")){
            rb.velocity = new Vector3(0, 0, -2);
        }
          //Right: x++
        if(Input.GetKey("down")){
             rb.velocity = new Vector3(2, 0, 0);
        }
        //Left: y--
        if(Input.GetKey("up")){
             rb.velocity = new Vector3(-2, 0, 0);
        }
    }

    //Verifca daca atinge pamantul:
    
    bool IsGrounded(){
        // arg1: pozitia sferei
        // ar2: dimensiunea
        //ar3: Layer Mask
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);
       
    }

    //Verific daca Capsula a atins Enamy Head
    //Daca a atins, inamicul este invins
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enamy Head")){
             Destroy(collision.transform.parent.gameObject);
             rb.velocity = new Vector3(rb.velocity.x, 5, rb.velocity.z);
        
        }
    }
    
}

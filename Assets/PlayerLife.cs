using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerLife : MonoBehaviour
{
    bool dead = false;
    //Adaugare Audio/Sunete cand va muri
    [SerializeField] AudioSource deathSound;

    //Poate muri in orice moment.
    //Verificam daca s-a ajuns la y = -1;
    private void Update(){
        if(transform.position.y < -6f && !dead){
            Die();
        }
    }

   private void OnCollisionEnter(Collision colision){
    if(colision.gameObject.CompareTag("Enamy")){
    //Player: invisible
    //nu mai este afectat de coliziuni
    //GetComponent<Rigidbody>().isKinematic = true;
    // GetComponent<PlayerMovement>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        Die();
    }
   }
   void Die(){
    //Delay in secunde
    Invoke(nameof(ReloadLevel), 1f);
    dead = true;
    Debug.Log("Death");
    deathSound.Play();
   }

   void ReloadLevel(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

 
}

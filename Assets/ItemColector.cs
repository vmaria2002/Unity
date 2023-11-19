using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemColector : MonoBehaviour
{
  //numarul de steaguri colectate:
   int flags = 0;
  [SerializeField] TMP_Text flagsTest;
  //Sunete la colectare steaguri:
    [SerializeField] AudioSource collectionSound;


  private void OnTriggerEnter(Collider other){
  if(other.gameObject.CompareTag("Flag")){
    //Am atins steagul, va disparea
    Destroy(other.gameObject);
    flags++;
    // Debug.Log("Steaguri colectate "+flags);
    flagsTest.SetText("Steaguri colectate: " + flags);

    //Pornire sunete:
    collectionSound.Play();
   }
  }
}

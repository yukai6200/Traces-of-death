using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
 private void OnTriggerEnter(Collider other) 
 {
     CharacterController character = other.GetComponent<CharacterController>();

     if (character != null)
     {
          Debug.Log(other.name + "has won0");
     }   
 }
}

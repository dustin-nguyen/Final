using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
   public GameObject LapCompleteTrig, HalfLapTrig;

   void OnTriggerEnter() {
       LapCompleteTrig.SetActive (true);
       HalfLapTrig.SetActive (false);
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_damage : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Enemy"))
        {
            GameSystem.Instance.StopTimer();
            GameSystem.Instance.FinishRun();
            Destroy(other.gameObject);
        }
    }

}

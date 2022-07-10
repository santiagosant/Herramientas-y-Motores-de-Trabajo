using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ia : MonoBehaviour
{

    public float range_alert;
    public float speed;
    public LayerMask player_layer;
    public Transform player;
    bool is_in_range;

    void Update()
    {
        is_in_range = Physics.CheckSphere(transform.position, range_alert, player_layer);


        if (is_in_range == true)
        {
            Vector3 see = new Vector3(player.position.x, transform.position.y, player.position.z);
            Vector3 go = new Vector3(player.position.x, player.position.y, player.position.z);
            transform.LookAt(see);
            transform.position = Vector3.MoveTowards(transform.position, go, speed * Time.deltaTime);
        }

    }

}

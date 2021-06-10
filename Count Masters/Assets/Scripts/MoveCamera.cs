using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Transform player;
    Vector3 offset;
    public GameObject ref_player;
    Player trigger_stop;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = player.position - transform.position;
        trigger_stop = ref_player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger_stop.isDead) { return; }
        transform.position = player.position - offset;
    }
}

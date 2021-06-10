using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerParticle : MonoBehaviour
{
    public GameObject player;
    Player trigger;
    ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        trigger = player.GetComponent<Player>();
        particles = GetComponent<ParticleSystem>();   
    }

    private void Update()
    {
       
    }
}

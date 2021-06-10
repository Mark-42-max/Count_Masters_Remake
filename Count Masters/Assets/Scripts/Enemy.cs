using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    Player toggle_death;

    public GameObject particles;
    ParticleSystem blood;

    private void Start()
    {
        toggle_death = player.GetComponent<Player>();
        blood = particles.GetComponent<ParticleSystem>();
    }
    private void Update()
    {
        if (toggle_death.isDead)
        {
            blood.Play();
        }
    }
}


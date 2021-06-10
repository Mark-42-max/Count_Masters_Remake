using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController player;

    [SerializeField] private float speed = 5.0f;    //the speed at which player moves
    [SerializeField] private float grav_vel = -1f;    //the gravitational speed

    private float dir_x;
    private float velocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 movement = Vector3.zero;   //vector 3 for player

        // X
        if (Input.GetKey(KeyCode.A))
        {
            dir_x = -speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir_x = speed;
        }

        movement.x = dir_x * Time.deltaTime;

        // Y
        if (player.isGrounded)
        {
            velocity = -0.5f;
        }
        else
        {
            velocity += grav_vel;
        }
        movement.y = velocity * Time.deltaTime;

        // Z
        movement.z = speed * Time.deltaTime;


        player.Move(movement);
    }
}

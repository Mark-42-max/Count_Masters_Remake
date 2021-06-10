using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController player;

    [SerializeField] readonly private float speed = 8.0f;    //the speed at which player moves
    [SerializeField] readonly private float grav_vel = -1f;    //the gravitational speed


    private float velocity = 0.0f;
    public bool isDead = false;

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

        movement.x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

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
        //movement.z = speed * Time.deltaTime;


        player.Move(movement);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            isDead = !isDead;
            Destroy(hit.gameObject, 1.0f);
            Destroy(gameObject, 1.0f);           
        }
    }
}

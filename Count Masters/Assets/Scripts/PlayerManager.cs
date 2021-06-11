using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool trigger_move = false;
    Player control;

    public List<GameObject> players;
    Transform position;
    Vector3 r_LineUp = new Vector3(1, 0, -1);
    Vector3 l_LineUp = new Vector3(-1, 0, -1);

    private void Awake()
    {
        players = new List<GameObject>();
        position = players[0].transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        players[0].AddComponent<Player>();
        control = players[0].GetComponent<Player>();
        trigger_move = !trigger_move;
        Instantiate(players[0], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PowerUp(int numberOfPlayers)
    {
        for(int i=1; i<=(numberOfPlayers/2); i++)
        {
            Vector3 pos = position.position + r_LineUp;
            Instantiate(players[0], pos, Quaternion.identity);      //for instantiating at left back

            pos = position.position + l_LineUp;
            Instantiate(players[0], pos, Quaternion.identity);      //for instantiating at right back
        }
    }
}

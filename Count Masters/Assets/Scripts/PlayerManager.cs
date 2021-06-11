using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] player;  //for player
    
    Rigidbody[] rb;     //for deetcting each collision


    // Start is called before the first frame update
    void Start()
    {
        GameObject go;
        go = Instantiate(player[0], transform);
        go.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

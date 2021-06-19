using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public GameObject manager;  //reference to player manager
    Transform pos;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        pos = manager.transform;
        offset = pos.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos.position - offset;
    }
}

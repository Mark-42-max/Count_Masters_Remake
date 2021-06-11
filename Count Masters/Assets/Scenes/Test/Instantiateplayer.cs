using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiateplayer : MonoBehaviour
{
    public List<GameObject> player = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player[0], transform);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

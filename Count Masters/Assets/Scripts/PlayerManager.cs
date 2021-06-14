using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] player;  //for initial character
    private List<GameObject> army = new List<GameObject>();  //for army

    Transform place;


    GameObject go;


    // Start is called before the first frame update
    void Start()
    {
        go = Instantiate(player[0]);
        go.transform.SetParent(transform);
        army.Add(go);
        var position = new Vector3(Random.Range(-10, 10), 1.51f, Random.Range(-10, 10));
        go = Instantiate(player[0], position, Quaternion.identity);
        go.transform.SetParent(transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }
}

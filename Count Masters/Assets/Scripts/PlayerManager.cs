using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] player;  //for initial character
    readonly private List<GameObject> army = new List<GameObject>();  //for army



    GameObject go;

    float dirX;
    public float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        go = Instantiate(player[0]);
        go.transform.SetParent(transform);
        army.Add(go);
        for (int i = 1; i <= 6; i++)
        {
            var position = new Vector3(Random.Range(-5, 5), -0.14f, Random.Range(-4, 0));
            go = Instantiate(player[0], position, Quaternion.identity);
            go.transform.SetParent(transform);
            army.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = Vector3.zero;

        dirX = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.x = dirX * Time.deltaTime;


        moveVector.z = speed * Time.deltaTime;

        transform.Translate(moveVector);
    }
}

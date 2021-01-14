using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaBalas : MonoBehaviour
{
    public GameObject balas;
    public GameObject cano;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(balas, new Vector3(cano.transform.position.x, cano.transform.position.y, cano.transform.position.z), Quaternion.identity);
        }
    }
}

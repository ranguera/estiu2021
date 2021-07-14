using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarExplosio : MonoBehaviour
{
    public GameObject explosio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(explosio, Vector3.zero, Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey(KeyCode.Space))
        {
            //print("getkey");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("getkeyDown");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("getkeyUp");
        }

        if(Input.GetMouseButton(0))
        {
            print("mouse");
        }
    }
}

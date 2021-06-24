using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llum : MonoBehaviour
{
    private Light llum;
    // Start is called before the first frame update
    void Start()
    {
        llum = this.GetComponent<Light>();
        llum.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

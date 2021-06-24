using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public Test test;
    public Test test2;
    public Light llum;

    // Start is called before the first frame update
    void Start()
    {
        test.nova = 77f;
        test2.nova = 77f;
        test.Adeu();
        test2.Adeu();
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        llum.intensity -= .01f;
    }
}

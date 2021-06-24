using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int number;
    public float bigNumber = 15f;

    public float nova = 22f;
    private int moreBigNumbers;

    void Awake()
    {
        float f;
        print("awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        print(number);
    }

    // Update is called once per frame
    void Update()
    {
        print(nova);
    }

    void LateUpdate()
    {
        print("late");
    }

    private void Hola()
    {

    }

    public void Adeu()
    {
        print("Adeu");
    }
}

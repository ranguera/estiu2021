using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public Renderer rend;
    public Renderer rend2;

    private Color color;
    private Color color2;

    private bool canviaColor;

    // Start is called before the first frame update
    void Start()
    {
        color = rend.material.color;
        color2 = rend2.material.color;
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space))
        {
            canviaColor = true;

            StartCoroutine(Rutina());
        }


        if (color.r > 0f && canviaColor)
        {
            color.r -= 0.02f;
            rend.material.color = color;
        }
        else if( color.r == 0f)
        {
            canviaColor = false;
        }
    }

    private IEnumerator Rutina()
    {
        while(color2.g > 0f)
        {
            color2.g -= 0.01f;
            rend2.material.color = color2;
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class So : MonoBehaviour
{
    public AudioClip so1, so2;

    private AudioSource asrc;

    
    void Start()
    {
        asrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //    asrc.PlayOneShot(so1);

        //if (Input.GetKeyDown(KeyCode.Return))
        //    asrc.PlayOneShot(so2);

        if (Input.GetKeyDown(KeyCode.Space))
            AudioManager.Instance.PlaySound1();

        if (Input.GetKeyDown(KeyCode.Return))
            AudioManager.Instance.PlaySound2();

        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("escena2");
    }

    public void Boto()
    {
        asrc.PlayOneShot(so2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    private AudioSource asrc;

    // Start is called before the first frame update
    void Start()
    {
        asrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(FadeAndChange());
        }
    }

    private IEnumerator FadeAndChange()
    {
        while(asrc.volume > 0f)
        {
            asrc.volume -= 0.002f;
            yield return null;
        }

        print("abans de la pausa");
        yield return new WaitForSeconds(2f);
        print("despres de la pausa");

        SceneManager.LoadScene("scene2");
    }
}

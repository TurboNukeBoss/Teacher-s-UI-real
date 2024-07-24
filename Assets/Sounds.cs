using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource click;
    public AudioSource error;
    public GameObject dark;
    public GameObject bright;
    public TextMeshProUGUI modeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayClick()
    {
        click.Play();
    }
    public void PlayError()
    {
        error.Play();
    }
    public void Dark()
    {
        if (modeText.text == "Light Mode ON")
        {
            dark.SetActive(true);
            bright.SetActive(false);
            modeText.text = "Dark Mode ON";
        }
        else
        {
            dark.SetActive(false);
            bright.SetActive(true);
            modeText.text = "Light Mode ON";
        }
    }
}

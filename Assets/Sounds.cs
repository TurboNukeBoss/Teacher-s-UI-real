using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource click;
    public AudioSource error;
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
}

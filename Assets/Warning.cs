//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Warning : MonoBehaviour
{
    public float fadeTime;
    public TextMeshProUGUI fadeAwayText;
    public UnityEngine.UI.Image bg;
    public float alphaValue;
    private float fadeAwayPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        fadeAwayText = GameObject.Find("Canvas/Background/Warning").GetComponent<TextMeshProUGUI>();
        fadeAwayPerSecond = 1 / fadeTime;
        alphaValue = fadeAwayText.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeTime>0)
        {
            alphaValue -= fadeAwayPerSecond * Time.deltaTime;
            fadeAwayText.color = new Color(fadeAwayText.color.r, fadeAwayText.color.g, fadeAwayText.color.b, alphaValue);
            bg.color = new Color(bg.color.r, bg.color.g, bg.color.b, alphaValue);
            //Debug.Log(fadeAwayText.color);
            //Debug.Log(bg.color);
            fadeTime -= Time.deltaTime;
        }
    }
    public void Fade()
    {
        fadeTime = 2;
        fadeAwayText = GameObject.Find("Canvas/Background/Warning").GetComponent<TextMeshProUGUI>();
        fadeAwayPerSecond = 1 / fadeTime ;
        alphaValue = 1;
        bg.color = new Color(bg.color.r, bg.color.g, bg.color.b, 1);
        GameObject.Find("Click").GetComponent<Sounds>().PlayError();
    }
}

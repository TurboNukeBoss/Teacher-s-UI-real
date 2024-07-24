using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Warning2 : MonoBehaviour
{
    public float fadeTime;
    public TextMeshProUGUI fadeAwayText;
    public float alphaValue;
    private float fadeAwayPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeTime > 0)
        {
            alphaValue -= fadeAwayPerSecond * Time.deltaTime;
            fadeAwayText.color = new Color(fadeAwayText.color.r, fadeAwayText.color.g, fadeAwayText.color.b, alphaValue);
            fadeTime -= Time.deltaTime;
        }
    }
    public void Fade()
    {
        fadeTime = 2;
        fadeAwayText = GetComponent<TextMeshProUGUI>();
        fadeAwayPerSecond = 1 / fadeTime * 255;
        alphaValue = 255;
        fadeAwayText.color = new Color(fadeAwayText.color.r, fadeAwayText.color.g, fadeAwayText.color.b, 255);
    }
}

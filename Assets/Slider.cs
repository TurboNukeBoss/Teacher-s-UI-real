using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{
    public float sliderValue;
    public float min = -0.427f;
    public float max = 2.14f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,0,0);
            if(transform.position.x < min)
            {
                transform.position = new Vector3(min,0,0);
            }
            if(transform.position.x > max)
            {
                transform.position = new Vector3(max,0,0);
            }
            sliderValue = Mathf.Round(transform.position.x * 10) + 4;
        }
    }
}

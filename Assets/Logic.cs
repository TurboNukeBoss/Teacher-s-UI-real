using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public GameObject question;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void plusQuestion()
    {
        Instantiate(question, GameObject.Find("Canvas/Scroll View/Viewport/Content").transform);
    }
    public void minusQuestion()
    {
        
    }
}

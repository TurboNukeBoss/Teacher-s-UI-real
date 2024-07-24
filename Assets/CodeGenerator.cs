using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class CodeGenerator : MonoBehaviour
{
    public string data;
    public bool GenCodePressed;
    public int order = 0;
    public TMP_InputField codeField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Canvas/Scroll View").GetComponent<Question_broadcaster>().qnCount == order - 1)
        {
            order = 0;
            GenCodePressed = false;
            Debug.Log(data);
            codeField.text = data;
        }
    }

    public void GenCode()
    {
        data = null;
        GenCodePressed = true;
        order = 1;
        GameObject.Find("Canvas/Scroll View").GetComponent<Question_broadcaster>().currentQn = "1000";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChengyangsFireBase : MonoBehaviour
{
    public string classroom;
    public string data;
    public TMP_InputField classRoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        classroom = classRoom.text;
        data = GameObject.Find("Canvas/GenCodeButton").GetComponent<CodeGenerator>().data;
    }
}

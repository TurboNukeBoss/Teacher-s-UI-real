using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Toggler : MonoBehaviour, IPointerClickHandler
{
    public List<string> numbers = new List<string>() {"1","2","3","4"};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Canvas/Option" + gameObject.name[7].ToString());
        if (GameObject.Find("Canvas/Option" + gameObject.name[7].ToString()).GetComponent<InputField>().text != "")
        {
            string name = gameObject.name;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (name.Contains(numbers[i]))
                {
                    numbers.RemoveAt(i);
                    break;
                }
            }
            GameObject.Find("Canvas/Toggle " + numbers[0]).GetComponent<Toggle>().isOn = false;
            GameObject.Find("Canvas/Toggle " + numbers[1]).GetComponent<Toggle>().isOn = false;
            GameObject.Find("Canvas/Toggle " + numbers[2]).GetComponent<Toggle>().isOn = false;
        }
        else
        {
            GetComponent<Toggle>().isOn = false;
            GameObject.Find("Canvas/Background").GetComponent<Warning>().Fade();
            //GameObject.Find("Canvas/Background/Warning").GetComponent<Warning2>().Fade();
        }
    }
}

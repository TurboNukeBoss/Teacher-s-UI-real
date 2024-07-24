using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class LevelButton : MonoBehaviour
{
    //public GameObject parent;
    public Text questionText;
    public int qnCount;
    public GameObject scrollView;
    public string fst;
    public string snd;
    public string trd;
    public string fth;
    public InputField mfst;
    public InputField msnd;
    public InputField mtrd;
    public InputField mfth;
    public string amCorrect = "1:02:03:04:0";
    public bool prevClicked = false;
    public string myData;
    // Start is called before the first frame update
    void Start()
    {
        amCorrect = "1:02:03:04:0";
    //GetComponent<Text>().text = parent.GetComponent<Question_broadcaster>().qnCount.ToString();
    qnCount = GameObject.Find("Scroll View").GetComponent<Question_broadcaster>().quens.Count;
        scrollView = GameObject.Find("Canvas/Scroll View");
        mfst = GameObject.Find("Canvas/Option1").GetComponent<InputField>();
        msnd = GameObject.Find("Canvas/Option2").GetComponent<InputField>();
        mtrd = GameObject.Find("Canvas/Option3").GetComponent<InputField>();
        mfth = GameObject.Find("Canvas/Option4").GetComponent<InputField>();
        //gameObject.GetComponent<Button>().onClick.AddListener(SetMeAsCurrent);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.name = questionText.text;
        //Debug.Log(GameObject.Find("Canvas/Scroll View/Viewport/Content/1/InputField/Text Area/Text").GetComponent<TextMeshProUGUI>().text.ToString());
        myData = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + gameObject.name + "/InputField/Text Area/Text").GetComponent<TextMeshProUGUI>().text.ToString() + ": " + fst + "/SEPARATOR/" + snd + "/SEPARATOR/" + trd + "/SEPARATOR/" + fth + "/SEPARATOR/" + amCorrect + "/SEPARATOR/";
        //gameObject.name = questionText.text;
        //Debug.Log(GameObject.Find("Scroll View").GetComponent<Question_broadcaster>().qnCount + "from: lvlbtn");
        //Debug.Log(int.Parse(questionText.text.ToString()));
        if(GameObject.Find("Canvas/GenCodeButton").GetComponent<CodeGenerator>().GenCodePressed &&
            GameObject.Find("Canvas/GenCodeButton").GetComponent<CodeGenerator>().order.ToString() == gameObject.name)
        {
            GameObject.Find("Canvas/GenCodeButton").GetComponent<CodeGenerator>().data += myData;
            GameObject.Find("Canvas/GenCodeButton").GetComponent<CodeGenerator>().order += 1;
        }
       
        
    }

    public void SetMeAsCurrent()
    {
        scrollView.GetComponent<Question_broadcaster>().currentQn = gameObject.name;
    }
}

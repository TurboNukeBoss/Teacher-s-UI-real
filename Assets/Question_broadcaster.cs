using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using Unity.Properties;
using Unity.VisualScripting;
//using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Options
{
    public List<string> options;
    ReturnValueNameAttribute ReturnValueNameAttribute;
    public void AddList(string customer)
    {
        options.Add(customer);
    }
}
[System.Serializable]
public class ButtonNames
{
    public List<Options> overview;
}
public class Question_broadcaster : MonoBehaviour
{
    /*public GameObject qno;
    public GameObject qnt;
    public GameObject qntr;
    public GameObject qnf;
    public GameObject qnfi;
    public GameObject qnsi;
    public GameObject qnse;
    public GameObject qne;
    public GameObject qnn;
    public GameObject qnte;
    public GameObject qnel;*/
    private string qn;
    public GameObject buttonPrefab;
    public GameObject buttonParent;
    public List<string> quens = new List<string>();
    public int qnCount;
    public string prefabName;
    public string currentQn = "1";
    public string prevQn = "1";
    public InputField mfst;
    public InputField msnd;
    public InputField mtrd;
    public InputField mfth;
    // Start is called before the first frame update
    void Start()
    {
        qnCount = 1;
        /*qno.SetActive(false);
        qnt.SetActive(false);
        qntr.SetActive(false);
        qnf.SetActive(false);
        qnfi.SetActive(false);
        qnsi.SetActive(false);
        qnse.SetActive(false);
        qne.SetActive(false);
        qnn.SetActive(false);
        qnte.SetActive(false);
        qnel.SetActive(false);
        quens.Add(qno);
        quens.Add(qnt);
        quens.Add(qntr); 
        quens.Add(qnf);
        quens.Add(qnfi); 
        quens.Add(qnsi);
        quens.Add(qnse); 
        quens.Add(qne);
        quens.Add(qnn);
        quens.Add(qnt);
        quens.Add(qnel);*/
        GameObject newButton = Instantiate(buttonPrefab, buttonParent.transform);
        newButton.GetComponent<LevelButton>().questionText.text = qnCount.ToString();
        //newButton.GetComponent<Button>().onClick.AddListener(() => ShowInfo("yes", 3));
        newButton.GetComponent<Button>().onClick.AddListener(() => GameObject.Find("Click").GetComponent<Sounds>().PlayClick());

        quens.Add("1");
        //Debug.Log(quens);
        prevQn = "1";
        currentQn = "1";
    }

    // Update is called once per frame
    void Update()
    {
        
        /*string qns = "";
        for (int i = 0; i < quens.Count; i++)
        {
            
            GameObject hee = GameObject.Find((i+1).ToString());
            prefabName = (i + 1).ToString();
            //Debug.Log(prefabName);
            //Debug.Log(quens.overview.Count);
            qn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prefabName + "/InputField/Text Area/Text").GetComponent<TextMeshProUGUI>().text;
            qns += qn;
        }*/
        //Debug.Log(qns);
        //Debug.Log(qns);
        if(prevQn != currentQn)
        {
            GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fst = mfst.text;
            GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().snd = msnd.text;
            GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().trd = mtrd.text;
            GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fth = mfth.text;
            //SETS PREVIOUS QUESTION AMCORRECT TO BE OPTION TOGGLE ON SCREEN
            GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect = "1:" + Convert.ToInt32(GameObject.Find("Canvas/Toggle 1").GetComponent<Toggle>().isOn).ToString() + "2:" + Convert.ToInt32(GameObject.Find("Canvas/Toggle 2").GetComponent<Toggle>().isOn).ToString() + "3:" + Convert.ToInt32(GameObject.Find("Canvas/Toggle 3").GetComponent<Toggle>().isOn).ToString() + "4:" + Convert.ToInt32(GameObject.Find("Canvas/Toggle 4").GetComponent<Toggle>().isOn).ToString();
            //Debug.Log(GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect);
            prevQn = currentQn;
            mfst.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fst;
            msnd.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().snd;
           mtrd.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().trd;
            mfth.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fth;

            //SWITCHES TOGGLE BACK TO THE LAST QUESTION

            GameObject.Find("Canvas/Toggle 1").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[2] == "1"[0];
            GameObject.Find("Canvas/Toggle 2").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[5] == "1"[0];
            GameObject.Find("Canvas/Toggle 3").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[8] == "1"[0];
            GameObject.Find("Canvas/Toggle 4").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[11] == "1"[0];


        }
    }

    public void AddQns()
    {
        if (qnCount < 99)
        {
            //quens[qnCount].SetActive(true);
            qnCount++;
            GameObject newButton = Instantiate(buttonPrefab, buttonParent.transform);
            newButton.GetComponent<LevelButton>().questionText.text = qnCount.ToString();
            //newButton.GetComponent<Button>().onClick.AddListener(() => ShowInfo("yes", 3));
            newButton.GetComponent<Button>().onClick.AddListener(() => GameObject.Find("Click").GetComponent<Sounds>().PlayClick());
            quens.Add((quens.Count + 1).ToString());
            
        }
    }
    public void DeleteQns()
    {
        if (quens.Count > 1)
        {
            string fstt = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + (quens.Count-1).ToString()).GetComponent<LevelButton>().fst;
            string sndt = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + (quens.Count - 1).ToString()).GetComponent<LevelButton>().snd;
            string trdt = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + (quens.Count - 1).ToString()).GetComponent<LevelButton>().trd;
            string ftht = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + (quens.Count - 1).ToString()).GetComponent<LevelButton>().fth;
            string amCorrectt = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + (quens.Count - 1).ToString()).GetComponent<LevelButton>().amCorrect;
            Destroy(GameObject.Find("Canvas/Scroll View/Viewport/Content/" + qnCount.ToString()));
            quens.RemoveAt(quens.Count - 1);
            qnCount--;
            if (int.Parse(prevQn) > quens.Count)
            {
                prevQn = (quens.Count).ToString();
                currentQn = prevQn;
                GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fst = fstt;
                GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().snd = sndt;
                GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().trd = trdt;
                GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fth = ftht;
                GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect = amCorrectt;
                mfst.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fst;
                msnd.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().snd;
                mtrd.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().trd;
                mfth.text = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().fth;
                GameObject.Find("Canvas/Toggle 1").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[2] == "1"[0];
                GameObject.Find("Canvas/Toggle 2").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[5] == "1"[0];
                GameObject.Find("Canvas/Toggle 3").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[8] == "1"[0];
                GameObject.Find("Canvas/Toggle 4").GetComponent<Toggle>().isOn = GameObject.Find("Canvas/Scroll View/Viewport/Content/" + prevQn).GetComponent<LevelButton>().amCorrect[11] == "1"[0];
            }
        }
    }

    public void ShowInfo(string answers, int whichCor)
    {
        Debug.Log(answers + whichCor);
    }

}

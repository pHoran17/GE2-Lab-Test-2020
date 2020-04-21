using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehavior : MonoBehaviour
{
    //tWEAK TO ALTER TAGS OF LIGHTS AS THEY CHANGE
    GameObject curLight;
    //public GameObject center;
    bool isG = false;
    bool isY = false;
    bool isR = false;
    public Color[] colors = new Color[3];
    Color curColor;

    // Start is called before the first frame update
    void Start()
    {
        colors[0] = Color.green;
        colors[1] = new Color(255, 255, 0);
        colors[2] = Color.red;
        curLight = this.gameObject;
        curColor = this.gameObject.GetComponent<Renderer>().material.color;
        if (curColor == colors[0])
        {
            isG = true;
            this.gameObject.tag = "GreenLight";
        }
        else if (curColor == colors[1])
        {
            isY = true;
            this.gameObject.tag = "OtherLight";
        }
        else if (curColor == colors[2])
        {
            isR = true;
            this.gameObject.tag = "OtherLight";
        }
    }
    public void OnEnable() 
    {
        //Didnt allow lights to change color independantly
        /*if(curColor == colors[0]) 
        {
            StartCoroutine(changeYellow(Random.Range(5, 10)));
        }
        else if (curColor == colors[1])
        {
            StartCoroutine(changeRed(4));
        }
        else if (curColor == colors[2])
        {
            StartCoroutine(changeYellow(Random.Range(5, 10)));
        }*/
        
    }
    // Update is called once per frame
    void Update()
    {
        int grChangeTime = Random.Range(5, 10);
        int yelChangeTime = 4;

        if(isG == true) 
        {
            isG = false;
            StartCoroutine(changeYellow(yelChangeTime));
        }
        else if (isY == true) 
        {
            isY = false;
            StartCoroutine(changeRed(grChangeTime));
        }
        else if (isR == true) 
        {
            isR = false;
            StartCoroutine(changeGreen(grChangeTime));
        }
    }
    IEnumerator changeGreen(float t) 
    {
        Color c = colors[0];
        curColor = c;
        var tlRend = this.gameObject.GetComponent<Renderer>();
        tlRend.material.SetColor("_Color", curColor);
        this.gameObject.tag = "GreenLight";
        yield return new WaitForSeconds(t);
        isG = true;
        isR = false;
        isY = false;
        yield break;

    }
    IEnumerator changeYellow(float t)
    {
        Color c = colors[1];
        curColor = c;
        var tlRend = this.gameObject.GetComponent<Renderer>();
        tlRend.material.SetColor("_Color", curColor);
        this.gameObject.tag = "OtherLight";
        yield return new WaitForSeconds(t);
        isY = true;
        isG = false;
        isR = false;
       yield break;
    }
    IEnumerator changeRed(float t)
    {
        Color c = colors[2];
        curColor = c;
        var tlRend = this.gameObject.GetComponent<Renderer>();
        tlRend.material.SetColor("_Color", curColor);
        this.gameObject.tag = "OtherLight";
        yield return new WaitForSeconds(t);
        isR = true;
        isY = false;
        isG = false;
        yield break;
    }
}

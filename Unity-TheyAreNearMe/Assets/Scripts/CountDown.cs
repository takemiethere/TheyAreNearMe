using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
    public float TimeStart = 60f;
    public Text TextBox;
    bool stopTime = true;
    //Start is called before the first frame update
    void Start()
    {
        TextBox.text = TimeStart.ToString();
    }

    //Update is called once per frame
    void Update()
    {
        if (stopTime)
        {
            TimeStart -= Time.deltaTime;
            TextBox.text = Mathf.Round(TimeStart).ToString();
            //TextBox.text = TimeStart.ToString();
        }
        if (TimeStart <= 0.0f)
        {
            stopTime = false;
        }
    }
}
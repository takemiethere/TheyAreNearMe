using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Timeline;

public class Timer : MonoBehaviour
{
    public GameObject WinUI;

    [Header("Component")]
    public TextMeshProUGUI timerText;
    
    [Header("Time Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")] 
    public bool hasLimit;
    public float timerLimit;

    [Header("Format Settings")] 
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();

    // Start is called before the first frame update
    void Start()
    {
        timeFormats.Add(TimerFormats.Whole, "0");
        timeFormats.Add(TimerFormats.TenthDecimal, "0.0");
        timeFormats.Add(TimerFormats.HundrethsDecimal, "0.00");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

        if (hasLimit&&((countDown&& currentTime<=timerLimit||(!countDown&&currentTime>=timerLimit))))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color=Color.red;
            enabled = false;
            Win();
        }
        SetTimerText();
    }

    private void SetTimerText()
    {
        //old
        // timerText.text = currentTime.ToString("0.0");
        timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
    }

    public enum TimerFormats
    {
        Whole,
        TenthDecimal,
        HundrethsDecimal
    }

    public void Win()
    {
        Time.timeScale = 0;
        SceneController.OpenwinnerUI = true;
        WinUI.SetActive(true);
        Cursor.visible = true;
    }
}

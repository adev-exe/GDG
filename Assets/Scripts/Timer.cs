using System.Collections;
using UnityEngine;
using TMPro;

//this class is to run the timer
public class Timer : MonoBehaviour
{
    public TMP_Text textBox;

    int current_time = 0;
    float minutes = 0;
    float seconds = 0;

    void Start()
    {
        //This updates the text feild once every second.
        textBox = GetComponent<TMP_Text>();
        textBox.text = current_time.ToString();
        StartCoroutine(RunEverySecond());
    }


    void Update()
    {
        RunEverySecond();
    }

    //increases the current time value by one every second
    //then calculates the time in mins:seconds
    public IEnumerator RunEverySecond()
    {
        while (true)
        {
            current_time += 1;
            minutes = Mathf.FloorToInt(current_time / 60);
            seconds = Mathf.FloorToInt(current_time % 60);
            textBox.text = string.Format("{0:00}:{1:00}", minutes, seconds);

           // textBox.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);

            yield return new WaitForSeconds(1.0f);

        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Times : MonoBehaviour
{
    [Header ("Current Time")]
    public string currentTime;
    public static string sCurrentTime;

    int Year;
    int Month;
    int Day;
    int Hour;
    int Minute;
    int Second;

    [Header ("Last Time")]
    public string lastTime;
    public static string sLastTime;

    int lastYear;
    int lastMonth;
    int lastDay;
    int lastHour;
    int lastMinute;
    int lastSecond;

    public float updateTime;

    [Header ("Time Elapsed")]
    public string elapsedTime;
    public static string sElapsedTime;

    public static int elapsedYear;
    public static int elapsedMonth;
    public static int elapsedDay;
    public static int elapsedHour;
    public static int elapsedMinute;
    public static int elapsedSecond;

    public static int totalSeconds;

    void Awake()
    {
        lastYear = PlayerPrefs.GetInt("Year");
        lastMonth = PlayerPrefs.GetInt("Month");
        lastDay = PlayerPrefs.GetInt("Day");
        lastHour = PlayerPrefs.GetInt("Hour");
        lastMinute = PlayerPrefs.GetInt("Minute");
        lastSecond = PlayerPrefs.GetInt("Second");
    }

    void Start()
    {
        lastTime = lastDay.ToString("00") + "/" + lastMonth.ToString("00") + "/" + lastYear.ToString("0000") + " - " + lastHour.ToString("00") + ":" + lastMinute.ToString("00") + ":" + lastSecond.ToString("00");

        StartCoroutine(ElapsedTime());

        StartCoroutine(UpdateLastData());
    }

    IEnumerator UpdateLastData()
    {
        PlayerPrefs.SetInt("Year", Year);
        PlayerPrefs.SetInt("Month", Month);
        PlayerPrefs.SetInt("Day", Day);
        PlayerPrefs.SetInt("Hour", Hour);
        PlayerPrefs.SetInt("Minute", Minute);
        PlayerPrefs.SetInt("Second", Second);

        yield return new WaitForSeconds(updateTime);
    }

    void Update()
    {
        if (sLastTime != lastTime) {sLastTime = lastTime;}
        if (sCurrentTime != currentTime) {sCurrentTime = currentTime;}
        if (sElapsedTime != elapsedTime) {sElapsedTime = elapsedTime;}
        Year = System.DateTime.Now.Year;
        Month = System.DateTime.Now.Month;
        Day = System.DateTime.Now.Day;
        Hour = System.DateTime.Now.Hour;
        Minute = System.DateTime.Now.Minute;
        Second = System.DateTime.Now.Second;

        currentTime = Day.ToString("00") + "/" + Month.ToString("00") + "/" + Year.ToString("0000") + " - " + Hour.ToString("00") + ":" + Minute.ToString("00") + ":" + Second.ToString("00");
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Year", Year);
        PlayerPrefs.SetInt("Month", Month);
        PlayerPrefs.SetInt("Day", Day);
        PlayerPrefs.SetInt("Hour", Hour);
        PlayerPrefs.SetInt("Minute", Minute);
        PlayerPrefs.SetInt("Second", Second);
    }

    IEnumerator ElapsedTime()
    {
        yield return new WaitForSeconds(0.1f);
        elapsedYear = Year - lastYear;
        elapsedMonth = Month - lastMonth;
        elapsedDay = Day - lastDay;
        elapsedHour = Hour - lastHour;
        elapsedMinute = Minute - lastMinute;
        elapsedSecond = Second - lastSecond;
        yield return new WaitForSeconds(0.1f);
        totalSeconds = elapsedSecond + elapsedMinute * 60 + elapsedHour * 3600 + elapsedDay * 86400 + elapsedMonth * 2592000 + elapsedYear * 31536000;
        elapsedTime = elapsedDay.ToString("00") + "/" + elapsedMonth.ToString("00") + "/" + elapsedYear.ToString("0000") + " - " + elapsedHour.ToString("00") + ":" + elapsedMinute.ToString("00") + ":" + elapsedSecond.ToString("00");
    }
}

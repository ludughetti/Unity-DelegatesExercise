using System.Collections;
using System.Collections.Generic;
using Exercise1_Delegates.Timer;
using TMPro;
using UnityEngine;

public class TimerView : MonoBehaviour
{
    [SerializeField] private TMP_Text timerNumber;

    [SerializeField] private SecondsCounter secondsCounter;

    private void OnEnable()
    {
        secondsCounter.onSecondPassed += HandleSecondPassed;
    }

    private void OnDisable()
    {
        secondsCounter.onSecondPassed -= HandleSecondPassed;
    }

    private void HandleSecondPassed(int currentSeconds)
    {
        timerNumber.text = secondsCounter.ToString();
    }
}

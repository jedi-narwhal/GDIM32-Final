using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;
    float time = 20f;
    
    void Update()
    {
        time -= Time.deltaTime;
        _timerText.text = time.ToString("F2");

        if (time <= 0)
        {
            Debug.Log("Time Over");
        }
    }
}

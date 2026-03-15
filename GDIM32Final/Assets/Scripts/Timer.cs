using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;

    //[SerializeField] private GameObject _gameOverMenu;
    public float time = 5f;


    void Awake()
    {
        _timerText.enabled = false;
    }
    
    void Update()
    {
        if (player.Instance._dialogueUI._dialogueOver == true)
        {
            _timerText.enabled = true;
            time -= Time.deltaTime;
            _timerText.text = time.ToString("F2");
        }
        

        if (time <= 0)
        {
            Debug.Log("Time Over");
            gameObject.SetActive(false);
            player.Instance._ui.GameOver();
        }
    }
}

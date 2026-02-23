using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    void Start()
    {
        _startMenu.SetActive(true);
    }

    public void GameStart()
    {
        _startMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Debug.Log("Game Start");
    }
}
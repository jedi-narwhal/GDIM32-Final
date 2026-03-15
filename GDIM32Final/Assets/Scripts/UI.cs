using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;

    [SerializeField] private GameObject _gameoverMenu;

    [SerializeField] private GameObject _dialogue;
    void Awake()
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

    public void GameOver()
    {
        Time.timeScale = 0f;
        _gameoverMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("Game Over");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
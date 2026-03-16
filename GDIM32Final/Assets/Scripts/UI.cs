using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;

    [SerializeField] private GameObject _gameoverMenu;

    [SerializeField] private GameObject _gamewinMenu;

    [SerializeField] private GameObject _inventoryBattery;

    [SerializeField] private GameObject _inventoryKey;

    void Awake()
    {
        _startMenu.SetActive(true);
        _inventoryBattery.SetActive(false);
        _inventoryKey.SetActive(false);
    }
    public void GameStart()
    {
        _startMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Debug.Log("Game Start");

        _inventoryBattery.SetActive(true);
        _inventoryKey.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        _gameoverMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("Game Over");
    }

    public void GameWin()
    {
        Time.timeScale = 0f;
        _gamewinMenu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        player.Instance.InvokeEndGame();
        Debug.Log("Game Win");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
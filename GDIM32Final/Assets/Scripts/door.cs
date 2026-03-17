using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class door : MonoBehaviour

{

    [SerializeField] private GameObject _gameoverMenu;
    [SerializeField]  public TMP_Text _lockedText;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenDoor()
    {
        if  (player.Instance._hasKey && player.Instance._hasBattery)
        {
  
            player.Instance._ui.GameWin();
            //Time.timeScale = 0f;
             
        }
        else
        {
            _lockedText.text = "You need a key!";
            _lockedText.gameObject.SetActive(true);

     
        }
    }
}

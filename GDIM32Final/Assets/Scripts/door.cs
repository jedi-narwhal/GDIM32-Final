using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour

{
     public bool _hasKey = false;
    [SerializeField] private GameObject _gameoverMenu;
    [SerializeField] public GameObject _lockedtext;
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
        //if (player.Instance._hasKey == true && )
    }
  // show win screen/diable timer and player

   void OnMouseUpAsButton()
    {
        if  (player.Instance._hasKey)
        {
            _gameoverMenu.SetActive(true);
            player.Instance._ui.GameOver();
            Time.timeScale = 0f;
             
        }
        else
        {
             _lockedtext.SetActive(true);      
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class audiomanager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource _clicksound;
    [SerializeField] private AudioSource _endsound;
  
    [SerializeField] private player _player;
   [SerializeField] private GameObject _door;

    void Start()
    {
        player.Instance.Click+= HandleClick;
        player.Instance.EndGame+= HandleEndgame;// hook when the thing is done most likely going to be in ui or timer 
    }

    // Update is called once per frame
    void Update()
    {
        //pickup,end time, open door
    }

    void HandleClick()
    {
        _clicksound?.Play();

    }


void HandleEndgame()
    {

        _endsound?.Play();

    }

}

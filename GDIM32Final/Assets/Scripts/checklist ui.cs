using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checklistui : MonoBehaviour
{
    [SerializeField] private GameObject _batteryUI;
    [SerializeField] private GameObject _keyUI;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _batteryUI.SetActive(false);
        _keyUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.Instance._hasBattery == true)
        {
            _batteryUI.SetActive(true);
        }
        if (player.Instance._hasKey == true)
        {
            _keyUI.SetActive(true);
        }
    }
}

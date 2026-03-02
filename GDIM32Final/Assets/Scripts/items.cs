using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public abstract class items : MonoBehaviour
{

[SerializeField] private GameObject _battery;
[SerializeField] private GameObject _key;
[SerializeField] private GameObject _door;


    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public  virtual void Pickup()
    {
        //Inventory.instance.AddItem(itemName);
        //gameObject.SetActive(false);
        //is this how we want to set up the inventory
    }

}

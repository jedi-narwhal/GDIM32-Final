using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class items : MonoBehaviour
{

//[SerializeField] private GameObject _battery;
//[SerializeField] private GameObject _key;
//[SerializeField] private GameObject _door;
    //public delegate void ObjectClicked();
    //public event ObjectClicked click;


    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void Pickup()
    {
        gameObject.SetActive(false);
       // click?.Invoke();
    }

}

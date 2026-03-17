using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_item : MonoBehaviour
{
 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            GameObject clickedObject = hit.collider.gameObject;

            items item = hit.collider.GetComponent<items>();
            if (item != null)
            {
                item.Pickup();
                player.Instance.InvokeClick();
            }

            // ✅ Now inside the raycast block
            door doorScript = hit.collider.GetComponent<door>();
            if (doorScript != null)
            {
                doorScript.OpenDoor();
            }
        }
    }
    }
}

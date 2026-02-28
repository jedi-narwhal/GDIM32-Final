using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : items
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Pickup()
    {
        base.Pickup();
        player.Instance._hasBattery = true;
        gameObject.SetActive(false);
    }
}

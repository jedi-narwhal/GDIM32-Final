using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : items
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
        player.Instance._hasKey = true;
    }
}

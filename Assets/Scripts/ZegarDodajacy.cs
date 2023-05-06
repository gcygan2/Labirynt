using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZegarDodajacy : PickUp
{
    public override void Picked()
    {
        GameManager.gameManager.AddTime(5);
        Destroy(this.gameObject);
    }
}

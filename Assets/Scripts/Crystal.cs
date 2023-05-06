using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : PickUp
{
    public override void Picked()
    {
        GameManager.gameManager.AddPoints(5);
        Destroy(this.gameObject);
    }
}

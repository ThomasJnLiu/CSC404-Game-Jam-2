using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : BaseObject
{
    // Start is called before the first frame update
    protected new void Start()
    {
        base.Start();
        this.isMoveable = true;
    }
}

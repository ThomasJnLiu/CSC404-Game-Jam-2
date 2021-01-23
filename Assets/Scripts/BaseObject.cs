using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    // BaseObject: contains a boolean (moveable) that controls whether its affected by environment
    protected bool isMoveable;
    protected Rigidbody rb;

    protected Wind wind;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        isMoveable = false;
        wind = GameObject.Find("Globals/Wind").GetComponent<Wind>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (isMoveable && wind.isActive) {
            rb.AddForce(new Vector3(wind.force, 0));
        }
    }
}

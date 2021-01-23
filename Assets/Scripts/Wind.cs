using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public bool isActive;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        force = -10.0f;
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setActive(bool isActive)
    {
        this.isActive = isActive;
    }
}

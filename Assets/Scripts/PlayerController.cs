using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 moveDir;
    public float moveSpeed, jumpForce, moveForce;
    public bool grounded;
    public bool canMoveBack = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveForce = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 5.0f);
    }

    void Move(){
        Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, (Input.GetAxis("Vertical") < 0 && !canMoveBack? 0 : Input.GetAxis("Vertical")));
        rb.AddForce(moveDir * moveForce);
    }

    void Jump(){
        if(Input.GetKeyDown("t")){
            if(grounded){
                Debug.Log("jump");
                rb.AddForce(new Vector3(0, jumpForce, 0));
            }
        }
    }

    
  public void SetGroundedState(bool _grounded)
  {
    grounded = _grounded;
  }
}

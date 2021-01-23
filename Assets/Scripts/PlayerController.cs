using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 moveDir;
    public float moveSpeed, jumpForce;
    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move(){
        Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // rb.MovePosition(rb.position + rb.transform.TransformDirection(moveDir)* moveSpeed);
        rb.velocity = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, rb.velocity.y, Input.GetAxis("Vertical")*moveSpeed);
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

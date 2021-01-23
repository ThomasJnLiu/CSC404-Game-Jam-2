using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 moveDir;
    public float moveSpeed, jumpForce, moveForce;
    public bool grounded;
    public bool canMoveBack = true;
    private Transform tr;
    public bool touchingButton = false;

    protected Wind wind;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveForce = 10.0f;
        tr = GetComponent<Transform>();
        if(SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "playArea"){
            Debug.Log("cant move back DUN NUNUNU");
            canMoveBack = false;
        }

        wind = GameObject.Find("Globals/Wind").GetComponent<Wind>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, 5.0f);     
        
        if(Input.GetKeyDown("g") && touchingButton){
            Debug.Log("button pressed");
            wind.setActive(true);
        }
    }

    void Move(){
        Vector3 moveDir = new Vector3((Input.GetAxis("Horizontal") < 0 && !canMoveBack? 0 : Input.GetAxis("Horizontal")), 0, Input.GetAxis("Vertical"));
        rb.AddForce(moveDir * moveForce);
    }

    void Jump(){
        if(Input.GetKeyDown("space")){
            if(grounded){
                Debug.Log("jump");
                SoundController.PlaySound("jump");
                rb.AddForce(new Vector3(0, jumpForce, 0));
            }
        }
    }

    
  public void SetGroundedState(bool _grounded)
  {
    grounded = _grounded;
  }

  public void OnTriggerEnter(Collider other){
    if (other.gameObject.tag == "DeathZone"){
    tr.position = Vector3.zero;
    }

    if(other.gameObject.tag == "Exit"){
    SceneManager.LoadScene("Level2");
    }

    if(other.gameObject.tag == "Button"){
        touchingButton = true;
    }
  }

    public void OnTriggerExit (Collider other){
        if(other.gameObject.tag == "Button"){
            touchingButton = false;
        }
    }   
}

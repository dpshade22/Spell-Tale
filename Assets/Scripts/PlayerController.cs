using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Rigidbody2D to be grabbed from the player
    private Rigidbody2D body; 
    
    private Vector2 moveInput;

    // change this to change the speed of the player
    public float moveSpeed = 2;

    public ContactFilter2D movementFilter;

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    public float collisionOffset = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      //body.AddForce(new Vector2(Input.GetAxis("Horizontal") * moveSpeed, Input.GetAxis("Vertical") * moveSpeed));
    }

    private void FixedUpdate() {
        // if there is no input then the payer is idle
        if(moveInput != Vector2.zero){
          // check for collisions here
          int collisionCount = body.Cast(
            moveInput,
            movementFilter,
            castCollisions,
            moveSpeed * Time.fixedDeltaTime + collisionOffset);
          
          if(collisionCount == 0){
            print("no collisions detected");
            body.MovePosition(body.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        }
      }
    }

    void OnMove(InputValue moveVal){
      print("OnMove called");
      moveInput = moveVal.Get<Vector2>();
    }
  }


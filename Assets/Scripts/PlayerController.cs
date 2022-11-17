using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Rigidbody2D to be grabbed from the player
    private Rigidbody2D body; 
    
    private Vector2 moveInput;

    // change this to change the speed of the player
    public float moveSpeed = 2f;


    public float collisionOffset = 0.05f;
    private float moveTimer;

    private Animator animator;

    public float stepX, stepY;
    private bool interactReady;
    [SerializeField] GameObject messageImage;
    [SerializeField] SceneController SceneController;

    public TextMeshProUGUI hoverText;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        moveSpeed = 3f;
        moveTimer = 0f;
        stepX = 0.05f;
        stepY = 0.05f;
        interactReady = false;
    }

    // Update is called once per frame
    void Update()
    {
      moveTimer += Time.deltaTime;
        if(Input.GetKey(KeyCode.W)){
          body.MovePosition(new Vector2(body.position.x, body.position.y + stepY));
        }
        if(Input.GetKey(KeyCode.A)){
          body.MovePosition(new Vector2(body.position.x - stepX, body.position.y));
        }
        if(Input.GetKey(KeyCode.S)){
          body.MovePosition(new Vector2(body.position.x, body.position.y - stepY));
        }
        if(Input.GetKey(KeyCode.D)){
          body.MovePosition(new Vector2(body.position.x + stepX, body.position.y));
        }
      
      OnMove();

      if(Input.GetKeyDown(KeyCode.E) && interactReady){
        messageImage.SetActive(true);
      }
    }

    private void FixedUpdate() {
    }

    void OnMove(){
      // walk up
      if(Input.GetKeyDown(KeyCode.W)){
        animator.SetBool("Walk Up", true);
        
      }
      if(Input.GetKeyUp(KeyCode.W)){
        animator.SetBool("Walk Up", false);
      }

      // walk right
      if(Input.GetKeyDown(KeyCode.D)){
        animator.SetBool("Walk Right", true);
      }
      if(Input.GetKeyUp(KeyCode.D)){
        animator.SetBool("Walk Right", false);
      }

      // walk down
      if(Input.GetKeyDown(KeyCode.S)){
        animator.SetBool("Walk Down", true);
      }
      if(Input.GetKeyUp(KeyCode.S)){
        animator.SetBool("Walk Down", false);
      }

      // walk left
      if(Input.GetKeyDown(KeyCode.A)){
        animator.SetBool("Walk Left", true);
      }
      if(Input.GetKeyUp(KeyCode.A)){
        animator.SetBool("Walk Left", false);
      }
    }

    public void InteractableTriggerEnter(string tag){
      if(tag == "Sign"){
        hoverText.SetText("Press E to Read");
        interactReady = true;
      }
    }

    public void InteractableTriggerExit(){
      hoverText.SetText("");
      interactReady = false;
    }

  }


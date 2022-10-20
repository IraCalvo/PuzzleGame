using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private float interactRange;
    [SerializeField] private KeyCode interactKey;
    private PlayerUI ui;
    public bool canMove = true;

    private Vector2 facingDirection;
    private Animator animator;
    private Vector2 input;
    public bool isMoving = false;
    private float lastX;
    private float lastY;

    public static PlayerController instance;

    public static bool isNewGame =  true;

    public GameObject mathExit;
    public GameObject leverExit;
    public GameObject boulderExit;
    public GameObject defaultPosition;

    void Awake()
    {
        instance = this;
        ui = FindObjectOfType<PlayerUI>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        Debug.Log("isNewGame: " + isNewGame);
        if(PlayerController.isNewGame == true)
        {
            PlayerController.isNewGame = false;
            Debug.Log("PlayerController Start: reset keyCount.");
            PlayerPrefs.SetInt("keyCount", 0);
            PlayerPrefs.SetString("lastCaveEntered", "newGame");
        }

        PlayerPrefs.GetInt("keyCount");
        Debug.Log("PlayerController Start: current amount of keys is:" + PlayerPrefs.GetInt("keyCount"));

        if(PlayerPrefs.GetString("lastCaveEntered") == "mathLevel")
        {
            this.transform.position = mathExit.transform.position;
        }
        if(PlayerPrefs.GetString("lastCaveEntered") == "leverLevel")
        {
            this.transform.position = leverExit.transform.position;
        }
        if(PlayerPrefs.GetString("lastCaveEntered") == "boulderLevel")
        {
            this.transform.position = boulderExit.transform.position;
        }
        if(PlayerPrefs.GetString("lastCaveEntered") == "newGame")
        {
            this.transform.position = defaultPosition.transform.position;
        }
    }

    void Update()
    {
        Move();
        CheckInteract();
    }


    void CheckInteract()
    {
        if(canMove)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, facingDirection, interactRange, 1 << 7);
        
            if(hit.collider != null)
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                ui.SetInteractText(hit.collider.transform.position, interactable.interactDescription);
                Debug.Log("Did hit");


                if(Input.GetKeyDown(interactKey))
                    interactable.Interact();
                    if(interactable.tag == "mathLevel")
                    {
                        PlayerPrefs.SetString("lastCaveEntered", "mathLevel");
                    }
                    if(interactable.tag == "leverLevel")
                    {
                        PlayerPrefs.SetString("lastCaveEntered", "leverLevel");
                    }
                    if(interactable.tag == "boulderLevel")
                    {
                        PlayerPrefs.SetString("lastCaveEntered", "boulderLevel");
                    }
            }
            else
            {
                ui.DisableInteractText();
            }
        }
    }

    void Move()
    {
        if(canMove)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if(input.x != 0 || input.y != 0) 
            {
                lastX = input.x;
                lastY = input.y;
            }

            animator.SetFloat("moveX", input.x);
            animator.SetFloat("moveY", input.y);
            animator.SetBool("isMoving", true);


            Vector2 velocity = new Vector2(input.x, input.y);

            rig.velocity = velocity * moveSpeed;
            if(Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
            {
                animator.SetFloat("moveX", lastX);
                animator.SetFloat("moveY", lastY);
                animator.SetBool("isMoving", false);
            }
            // Debug.Log("Last X,Y:" + lastX + lastY);
        }
        
    }

    public void AddKey()
    {
        
        PlayerPrefs.SetInt("keyCount", PlayerPrefs.GetInt("keyCount", 0) +1);
        Debug.Log("PlayerController AddKey: current amount of keys is:" + PlayerPrefs.GetInt("keyCount"));
    }

    public void PlayerCannotMove()
    {
        Debug.Log("can you see this?");
        canMove = false;
    }
    
    public void PlayerCanMoveAgain()
    {
        canMove = true;
    }


}

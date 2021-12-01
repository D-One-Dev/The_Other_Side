using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //character controller
    [SerializeField] private CharacterController controller;
    //speed value, gravity value, ground distance, jump height
    [SerializeField] private float speed = 12f, gravity = 9.81f, groundDistance, jumpHeight;
    //ground check point
    [SerializeField] private Transform groundCheck;
    //ground layer mask
    [SerializeField] private LayerMask groundMask;
    //player velocity
    private Vector3 velocity;
    //is player on ground
    private bool isGrounded;

    //input system
    private Controls controls;
    private void Awake()
    {
        controls = new Controls();
        //controls.Player.Jump.performed += context => Jump();
        
    }
    private void OnEnable()
    { controls.Enable(); }
    private void OnDisable()
    { controls.Disable(); }

    void Update()
    {
        //checking if player is on ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0) velocity.y = -gravity;
        //calculating movement
        float moveX = controls.Player.MoveX.ReadValue<float>();
        float moveZ = controls.Player.MoveZ.ReadValue<float>();
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        //moving player
        controller.Move(move * speed * Time.deltaTime);
        //gravity
        velocity.y -= gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    private void Jump()
    {
        //jumping
        if(isGrounded) velocity.y = Mathf.Sqrt(jumpHeight * -2f * -gravity);
    }
    
}

using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationAndMovementController : MonoBehaviour
{
    private InputActions inputActions;
    CharacterController characterController;
    Animator animator;
    Vector2 movementInput;
    Vector3 movement;
    private bool isMovementPressed;
    
    void Awake()
    {
        inputActions = new InputActions();
        inputActions.CharacterControls.Movement.started += OnMovementInput;
        inputActions.CharacterControls.Movement.canceled += OnMovementInput;
        inputActions.CharacterControls.Movement.performed += OnMovementInput;
        
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    private void OnMovementInput(InputAction.CallbackContext ctx)
    {
        movementInput = ctx.ReadValue<Vector2>();
        movement.x = movementInput.x;
        movement.z = movementInput.y;
        isMovementPressed = movementInput.x != 0 || movementInput.y != 0;
    }
    
    void Update()
    {
        UpdateAnimation();
        if (isMovementPressed)
        {
            //transform.rotation = Quaternion.LookRotation(movement);
        }
        
        //characterController.Move(movement * Time.deltaTime * 5);
    }

    private void UpdateAnimation()
    {
        animator.SetFloat("Forward", movement.z);
        animator.SetFloat("Sideways", movement.x);
        /*bool isWalking = animator.GetBool("isWalking");
        if (isMovementPressed && !isWalking)
        {
            animator.SetBool("isWalking", true);
        }
        else if (!isMovementPressed && isWalking)
        {
            animator.SetBool("isWalking", false);
        }*/
    }

    private void OnEnable()
    {
        inputActions.CharacterControls.Enable();
    }

    private void OnDisable()
    {
        inputActions.CharacterControls.Disable();

    }
}

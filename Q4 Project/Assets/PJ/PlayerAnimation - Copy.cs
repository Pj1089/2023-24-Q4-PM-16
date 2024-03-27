using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;

    /*private GameInput Input = null;
    private Rigidbody2D rb = null;
    private Vector2 moveVector = Vector2.zero;
    private Animator animator = null;

    private void Awake()
    {
        Input = new GameInput();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<animator>();
    }

    private void OnEnable()
    {
        Input.Enable();
        Input.Player.Move.performed += MovePerformed;
        Input.Player.Move.canceled += MoveCancelled;
    }

    private void OnDisable()
    {
        Input.Disable();
        Input.Player.Move.performed -= MovePerformed;
        Input.Player.Move.cancelled -= MoveCancelled;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveVector * moveSpeed;
    }

    private void MovePerformed(InputAction.CallbackContext callbackContext)
    {
        moveVector = callbackContext.ReadValue<Vector2>();
        if (moveVector.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        else
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        animator.SetBool("isRunning", true);
    }
    private void MoveCancelled(InputAction.CallbackContext callbackContext)
    {
        moveVector = Vecto2.zero;
        animator.SetBool("isRunning", false);
    }*/
}
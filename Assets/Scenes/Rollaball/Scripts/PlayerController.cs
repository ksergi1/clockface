using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour

{
    public float speed = 15;
    Rigidbody rb;
    private Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        
        movement = movementValue.Get<Vector2>();
        Debug.Log(movement);

        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(movement.x, 0f, movement.y); 
    }
}

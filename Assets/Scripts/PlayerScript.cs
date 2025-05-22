using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public int jump_vel = 5;
    public Rigidbody2D myRigidBodyComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBodyComponent.linearVelocity = Vector2.up * jump_vel;
        }
    }
}

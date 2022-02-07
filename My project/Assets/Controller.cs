using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float jump = 3f;
    public CharacterController controllerw;
    public Transform cam;
    public float turnSmoothTime=0.1f;
    private float turnSmoothV;
    public float speed = 6f;
    public Transform groundcheck;
    public LayerMask mask;
    public float gravity = -9.8f;
    public float groundDistance = 0.2f;
    private Vector3 veloctiy1;
    private bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, mask);

        if (isGrounded && veloctiy1.y<0)
        {
            veloctiy1.y = -2f;
        }
        
        
        float horizonatl = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizonatl, 0f, vertical).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z)* Mathf.Rad2Deg+cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothV,turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f)*Vector3.forward;
           
            controllerw.Move(moveDir * speed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            veloctiy1.y = Mathf.Sqrt(jump * -2.0f * gravity);
        }
        veloctiy1.y += gravity * Time.deltaTime;
        controllerw.Move(veloctiy1 * Time.deltaTime);
        
    }
    
}

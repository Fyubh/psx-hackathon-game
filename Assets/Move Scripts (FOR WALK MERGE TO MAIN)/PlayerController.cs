using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody _rb;

    public float rotationspeed = 10f;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 directionVector = new Vector3(v, 0, -h);

        if (directionVector.magnitude > Mathf.Abs(0.1f))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * 15);
        }

        animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        _rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
    }
}
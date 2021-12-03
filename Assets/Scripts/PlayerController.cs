using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;
    private GameObject focalPoint;

    [SerializeField] private float PlayerSpeed = 500f;
    [SerializeField] private float RotateSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, horizontalInput * RotateSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _rb.AddForce(gameObject.transform.forward * verticalInput * PlayerSpeed * 1.5f * Time.deltaTime);
        }
        else
        {
            _rb.AddForce(gameObject.transform.forward * verticalInput * PlayerSpeed * Time.deltaTime);
        }
    }
}

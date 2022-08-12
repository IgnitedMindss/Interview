using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController _controller;
    Animator animator;

    [SerializeField]
    private float _speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        if(Input.GetKey(KeyCode.S)){
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }else if(Input.GetKey(KeyCode.A)){
            transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
        }else if(Input.GetKey(KeyCode.D)){
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }else{
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }

        if(Mathf.Abs(horizontalInput) > 0f || Mathf.Abs(verticalInput) > 0f){
            animator.SetBool("IsWalking", true);
        }else animator.SetBool("IsWalking", false);

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = _speed * direction;

        _controller.Move(velocity * Time.deltaTime);
    }
}

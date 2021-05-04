using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerlizeField]
    private Rigidbody2D rigid2D;
    private Vector3 moveDirection = Vector3.zero;
    private float moveSpeed = 5.0f;


    private void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");


        moveDirection = new Vector3(x, y, 0);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }



}

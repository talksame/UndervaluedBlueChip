using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.0f;

    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;
    private float transform_x = 0.0f;

    [SerializeField]
    private int trapType = 0;


    void start()
    {

    }

    // Update is called once per frame
    void Awake()
    {
        if (trapType == 0)
        {
            moveSpeed = Random.Range(20, 45);
            transform_x = Random.Range(0.2f, 0.6f);
        }
        else if (trapType == 1)
        {
            moveSpeed = Random.Range(20, 80);
            transform_x = Random.Range(0.25f, 0.45f);
        }
    }
    void Update()
    {
        transform.localScale = new Vector3(transform_x, transform.localScale.y, transform.localScale.z);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTrap : MonoBehaviour
{
    [SerializeField]
    private float  moveSpeed = 0.0f;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;
    private float transform_x = 0.0f;

    [SerializeField]
    private int trapType = 0;


    //public float Transform_x => transform_x;



    void start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            transform_x = Random.Range(0.15f, 0.35f);
        }
    }
    void Update()
    {
        transform.localScale = new Vector3(transform_x, transform.localScale.y, transform.localScale.z);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void Destroy()
    {
        Destroy(spriteRenderer, 0.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy();
    }

    public float getsize()
    {
        return transform_x;
    }

    public int getType()
    {
        return trapType;
    }

    public void moveTo(Vector3 direction)
    {
        moveDirection = direction;
    }
}

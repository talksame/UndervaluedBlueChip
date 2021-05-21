using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Color color;
    private SpriteRenderer spriteRenderer;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 size_ob = Vector3.zero;
    private int moveSpeed = 0;
    private float transform_x = 0;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    private void Awake()
    {
        moveSpeed = Random.Range(13, 22);
        transform_x = Random.Range(15, 30);

    }

    private void Destroy()
    {
        Destroy(spriteRenderer, 2.5f);
    }

    private void Update()
    {
        moveDirection = new Vector3(0, -1, 0);


        transform.localScale = new Vector3(transform_x , transform.localScale.y, transform.localScale.z);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        Destroy();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("finish");
    }
}

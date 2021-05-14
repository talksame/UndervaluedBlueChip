using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Color color;
    private SpriteRenderer spriteRenderer;
    private int cnt = 0;
    private Vector3 moveDirection = Vector3.zero;
    private int moveSpeed = 0;



    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Destroy()
    {
        Destroy(spriteRenderer, 5.0f);
    }

    private void Update()
    {
        moveDirection = new Vector3(-1, 0 , 0);
        moveSpeed = Random.Range(13, 20);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        Destroy();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (cnt == 1)
        {
            Debug.Log("finish");
            Debug.Log(moveSpeed);
            //player.GetComponent<SpriteRenderer>().color = color;
        }
        else
        {
            cnt += 1;
        }
    }
}

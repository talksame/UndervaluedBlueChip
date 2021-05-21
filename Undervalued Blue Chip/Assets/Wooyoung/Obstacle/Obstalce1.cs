using UnityEngine;

public class Obstalce1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Color color;
    private SpriteRenderer spriteRenderer;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 size_ob = Vector3.zero;
    private int moveSpeed = 0;
    private float transform_y = 0;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    private void Awake()
    {
        moveSpeed = Random.Range(13, 22);
        transform_y = Random.Range(10, 20);

    }

    private void Destroy()
    {
        Destroy(spriteRenderer, 2.5f);
    }

    private void Update()
    {
        moveDirection = new Vector3(-1, 0, 0);


        transform.localScale = new Vector3(transform.localScale.x, transform_y, transform.localScale.z);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        Destroy();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("finish");
    }
}

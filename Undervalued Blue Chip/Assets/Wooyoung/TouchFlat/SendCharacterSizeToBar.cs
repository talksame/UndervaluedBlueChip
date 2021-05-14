
using UnityEngine;

public class SendCharacterSizeToBar : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    private Vector3 size = Vector3.zero;


    [SerializeField]
    private GameObject Character;
    private Vector3 player_size = Vector3.zero;

    [SerializeField]
    private float obstacleSpawnTime = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Character = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        obstacleSpawnTime += Time.deltaTime;
        if (obstacleSpawnTime < 17)
        {
            spriteRenderer.transform.localScale = new Vector3(obstacleSpawnTime * 4 , 2, 1);
        }
        else
        {
            obstacleSpawnTime = 0;
        }
        size = spriteRenderer.transform.localScale;



        //player_size = Character<Transform>.localScale;

        Debug.Log("size");
        Debug.Log(player_size);

    }
}

using UnityEngine;

public class ObstacleInstance : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabArray;


    private void Awake()
    {

        /*
        GameObject clone = Instantiate(boxPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        //Instantiate(boxPrefab, new Vector3(1, 1, 0), Quaternion.identity);

        clone.name = "Hello";

        clone.GetComponent<SpriteRenderer>().color = Color.black;
        clone.transform.localScale = new Vector3(2, 2, 0);
        */
        /*
        for ( int i = 0; i < 10; i++)
        {
            Vector3 position = new Vector3(-4.5f + i, 2, 0);
            Quaternion rotation = Quaternion.Euler(0, 0, i * 10);

            Instantiate(boxPrefab, position, rotation);
        }
        */
        for (int s = 0; s < 100; s++)
        {
            for (int i = 0; i < 10; i++)
            {
                int index = Random.Range(0, prefabArray.Length);
                Vector3 position = new Vector3(-4.5f + i, s, 0);
                Instantiate(prefabArray[index], position, Quaternion.identity);
            }

        }
    }
}

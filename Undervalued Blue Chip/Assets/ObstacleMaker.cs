
using UnityEngine;

public class ObstacleMaker : MonoBehaviour
{
    [SerializeField]
    private int obstacleCount = 1;

    [SerializeField]
    private GameObject[] obstaclePrefab;

    [SerializeField]
    private Transform[] randomPoint;
    private int currentObstacleCount = 0;
    private float obstacleSpawnTime = 0.0f;

    private void Update()
    {
        if ( currentObstacleCount + 1 > obstacleCount)
        {
            return;
        }
        obstacleSpawnTime += Time.deltaTime;

        if ( obstacleSpawnTime > 2.0f)
        {
            int index = Random.Range(0, randomPoint.Length);

            Vector3 position = randomPoint[index].position;

            GameObject clone = Instantiate(obstaclePrefab[index], position, Quaternion.identity);

            currentObstacleCount++;
            obstacleSpawnTime = 0.0f;
        }


    }

}


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

    [SerializeField]
    private GameObject alarmTrap;

    private void Update()
    {
        if ( currentObstacleCount + 1 > obstacleCount)
        {
            return;
        }
        obstacleSpawnTime += Time.deltaTime;

        if ( obstacleSpawnTime > 1.5f)
        {
            int index = Random.Range(0, randomPoint.Length);
            if ( index < 2)
            {
                Vector3 position = randomPoint[index].position;

                GameObject clone = Instantiate(obstaclePrefab[index], position, Quaternion.identity);
            }
            else
            {

                Vector3 position = randomPoint[index].position;
                

                GameObject alertLineClone = Instantiate(alarmTrap, position, Quaternion.identity);

                Destroy(alertLineClone);

                GameObject clone = Instantiate(obstaclePrefab[index], position, Quaternion.identity);

            }

            currentObstacleCount++;
            obstacleSpawnTime = 0.0f;
        }


    }

}

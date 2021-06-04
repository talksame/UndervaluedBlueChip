using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSucceedInf : MonoBehaviour
{
    [SerializeField]
    public IsTriggered isTriggered;
    public bool isSucceed = false;

    [SerializeField]
    private float successTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = 0;
        currentTime += Time.deltaTime;

        //Debug.Log(obstacleSpawnTime);

    }

    public bool get_suc()
    {
        return isSucceed;
    }
}

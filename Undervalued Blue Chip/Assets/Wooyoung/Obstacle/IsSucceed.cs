using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSucceed : MonoBehaviour
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
        if (currentTime > successTime)
        {
            if (isTriggered.get_die() == false)
            {
                isSucceed = true;
            }
        }

        //Debug.Log(obstacleSpawnTime);


    }

    public bool get_suc()
    {
        return isSucceed;
    }
}

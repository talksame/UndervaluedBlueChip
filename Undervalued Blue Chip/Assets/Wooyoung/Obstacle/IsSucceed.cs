using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsSucceed : MonoBehaviour
{
    [SerializeField]
    public IsTriggered isTriggered;
    public bool isSucceed = false;

    [SerializeField]
    private float successTime = 0.0f;

    public GameObject gameSuccessPanel;

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
        if (isSucceed == true)
         {
                gameSuccessPanel.SetActive(true);
         }
    }

    public bool get_suc()
    {
        return isSucceed;
    }
    
}

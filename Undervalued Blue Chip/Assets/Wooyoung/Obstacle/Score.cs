using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public IsTriggered isTriggered;

    [SerializeField]
    public IsSucceed isSucceed;

    [SerializeField]
    public float score;
    public int int_score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*100;

        int_score = (int)score;
        //Debug.Log(int_score);



    }

    public int get_score()
    {
        return int_score;
    }
}

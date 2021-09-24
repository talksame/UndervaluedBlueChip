using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    public IsTriggered isTriggered;

    [SerializeField]
    public float score;
    public int int_score;

    public Text pointsText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered.get_die() == false)
        {
            score += Time.deltaTime * 100;

            int_score = (int)score;
            //Debug.Log(int_score);

            pointsText.text = int_score.ToString() + " POINTS";

            int_score = (int)score;


        }
        Debug.Log(int_score);

    }

    public int get_score()
    {
        return int_score;
    }
}
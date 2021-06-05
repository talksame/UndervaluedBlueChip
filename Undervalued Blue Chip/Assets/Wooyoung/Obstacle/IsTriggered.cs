using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsTriggered : MonoBehaviour
{
    [SerializeField]
    public bool isDie = false;

    [SerializeField]
    public GameObject character;

    public GameObject gameOverPanel;
    public Text pointsText;

    public int scr;

    void Awake()
    {
        scr = GameObject.Find("character").GetComponent<Score>().get_score();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {

            if (collision.gameObject.transform.localScale.x + 0.35 < gameObject.transform.localScale.x)
            {
                isDie = true;
                //Debug.Log("finish");
            }
        }

        if (collision.CompareTag("Trap2"))
        {
            if ((collision.gameObject.transform.localScale.x) * 2.7 > gameObject.transform.localScale.x)
            {
                isDie = true;
                //Debug.Log("finish2");
            }
        }
    }

    public bool get_die()
    {
        return isDie;
    }


    private void Update()
    {
        if (isDie == true)
        {
            gameOverPanel.SetActive(true);
            pointsText.text = scr.ToString() + " POINTS";
        }
    }

}
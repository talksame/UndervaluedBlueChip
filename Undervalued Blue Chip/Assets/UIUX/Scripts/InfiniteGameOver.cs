using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniteGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Text pointsText;
    public GameObject gameOverPanel;
    public bool isDead = GameObject.Find("character").GetComponent<IsTriggered>().isDie;
    public int scr = GameObject.Find("character").GetComponent<Score>().int_score;
    private void Update()
    {
        if (isDead == true)
        {
            gameOverPanel.SetActive(true);
            pointsText.text = scr.ToString() + " POINTS";
        }
    }
}

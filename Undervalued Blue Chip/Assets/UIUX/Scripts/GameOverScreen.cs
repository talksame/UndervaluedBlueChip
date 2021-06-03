using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    bool gameOver;
    public GameObject GameOverPanel;
    private void Start()
    {
        GameObject gameObject = GameObject.Find("player");
        gameOver = gameObject.GetComponent<IsTriggered>().isDie;
    }

    private void Update()
    {
        if (gameOver == true)
        {
            GameOverPanel.SetActive(true);
        }
    }


}

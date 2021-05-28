using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsTriggeredBy1 : MonoBehaviour
{
    [SerializeField]
    public bool game = true;

    private void Update()
    {

        if (Get_Statue() == false)
        {
            Debug.Log("Game_over");
        }

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hello");
        if (collision.CompareTag("Trap"))
        {
            Debug.Log("hello");
            game = false;
        }
    }

    public bool Get_Statue()
    {
        return game;
    }
}

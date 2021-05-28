using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTriggeredBy1 : MonoBehaviour
{
    [SerializeField]
    public bool game = true;

    // Start is called before the first frame update
    void Start()
    {

    }

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
        Debug.Log("C_finish");
        game = false;
    }

    public bool Get_Statue()
    {
        return game;
    }
}

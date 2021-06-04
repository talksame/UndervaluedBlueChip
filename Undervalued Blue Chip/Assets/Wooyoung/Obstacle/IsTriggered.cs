using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTriggered : MonoBehaviour
{
    [SerializeField]
    public bool isDie = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trap"))
        {

            if (collision.gameObject.transform.localScale.x+0.35 < gameObject.transform.localScale.x )
            {
                isDie = true;
                Debug.Log("finish");
            }
        }

        if (collision.CompareTag("Trap2"))
        {
            if (collision.gameObject.transform.localScale.x > gameObject.transform.localScale.x-0.6 )
            {
                isDie = true;
                Debug.Log("finish2");
            }
        }
    }

    public bool get_die()
    {
        return isDie;
    }

}

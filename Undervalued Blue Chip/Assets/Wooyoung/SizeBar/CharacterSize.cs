using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSize : MonoBehaviour
{
    [SerializeField]
    private float maxSize = 2.0f;
    private float currentSize;


    public float MaxSize => maxSize;
    public float CurrentSize => currentSize;

    private void Awake()
    {
        currentSize = 0.5f;
    }

    private void Update()
    {
        currentSize = transform.localScale.x;

        if (currentSize > 2)
        {
            Debug.Log("Death");
        }
    }

}

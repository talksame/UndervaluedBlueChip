using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeBarViewer : MonoBehaviour
{
    [SerializeField]
    private CharacterSize characterSize;
    private Slider                  sliderSize;


    private void Awake()
    {
        sliderSize = GetComponent<Slider>();
    }

    private void Update()
    {/*
        sliderSize.value = (characterSize.CurrentSize-0.74f) / (characterSize.MaxSize-0.75f);
    */
     }
}

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
    {
        float a = characterSize.CurrentSize - 0.74f;
        float b = characterSize.MaxSize - 0.75f;
        sliderSize.value =  a / b;
    
    }
    
}

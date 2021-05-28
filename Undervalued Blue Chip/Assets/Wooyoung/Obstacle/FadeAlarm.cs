﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAlarm : MonoBehaviour
{
    private float fadeTime = 0.2f;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartMethod();
    }

    void StartMethod()
    {
        StartCoroutine("MyCoroutine");
    }

    private IEnumerator MyCoroutine()
    {
        while ( true)
        {
            yield return StartCoroutine(FadeEffect(1, 0));
            yield return StartCoroutine(FadeEffect(0, 1));
        }
    }

    private IEnumerator FadeEffect(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while ( percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            Color color = spriteRenderer.color;
            color.a = Mathf.Lerp(start, end, percent);
            spriteRenderer.color = color;
            yield return null;
        }

    }




}

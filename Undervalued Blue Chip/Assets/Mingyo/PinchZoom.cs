using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    float ZOOM_MAX_X = 1.4f;
    float ZOOM_MAX_Y = 1.4f;
    float ZOOM_MIN_X = 0.7f;
    float ZOOM_MIN_Y = 0.7f;
    float zoomSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        OnPinch();
    }

    private void OnPinch()
    {
        if (Input.touchCount != 2)
        {
            return;
        }

        float scaleX = transform.localScale.x;
        float scaleY = transform.localScale.y;
        Vector3 zoomScale;

        Touch firstTouch = Input.GetTouch(0);
        Touch secondTouch = Input.GetTouch(1);

        Vector2 firstTouchPreviousPosition = firstTouch.position - firstTouch.deltaPosition;
        Vector2 SecondTouchPreviousPosition = secondTouch.position - secondTouch.deltaPosition;

        float previousTouchDistance = (firstTouchPreviousPosition - SecondTouchPreviousPosition).magnitude;
        float currentTouchDistance = (firstTouch.position - secondTouch.position).magnitude;


        float zoomPower = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomSpeed * Time.deltaTime;

        if (previousTouchDistance <= currentTouchDistance)
        {
            zoomScale = new Vector3(1, 1, 0) * zoomPower;

            if (scaleX + zoomScale.x >= ZOOM_MAX_X && scaleY + zoomScale.y >= ZOOM_MAX_Y)
            {
                transform.localScale = new Vector3(ZOOM_MAX_X, ZOOM_MAX_Y, 0);
            }
            else
            {
                transform.localScale += zoomScale;
            }
        }
        else if (previousTouchDistance > currentTouchDistance)
        {
            zoomScale = new Vector3(-1, -1, 0) * zoomPower;

            if (scaleX + zoomScale.x <= ZOOM_MIN_X && scaleY + zoomScale.y <= ZOOM_MIN_Y)
            {
                transform.localScale = new Vector3(ZOOM_MIN_X, ZOOM_MIN_Y, 0);
            }
            else
            {
                transform.localScale += zoomScale;
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    float zoomSpeed = 0.05f;
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

        Touch firstTouch = Input.GetTouch(0);
        Touch secondTouch = Input.GetTouch(1);

        Vector2 firstTouchPreviousPosition = firstTouch.position - firstTouch.deltaPosition;
        Vector2 SecondTouchPreviousPosition = secondTouch.position - secondTouch.deltaPosition;

        float previousTouchDistance = (firstTouchPreviousPosition - SecondTouchPreviousPosition).magnitude;
        float currentTouchDistance = (firstTouch.position - secondTouch.position).magnitude;


        float zoomPower = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomSpeed;

        if (previousTouchDistance < currentTouchDistance)
        {
            if (scaleX >= 1.4 && scaleY >= 1.4)
            {
                return;
            }
            transform.localScale += new Vector3(1, 1, 0) * zoomPower * Time.deltaTime;
        }
        else if (previousTouchDistance > currentTouchDistance)
        {
            if (scaleX <= 0.7 && scaleY <= 0.7)
            {
                return;
            }
            transform.localScale += new Vector3(-1, -1, 0) * zoomPower * Time.deltaTime;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchZoom : MonoBehaviour
{
    [SerializeField]
    float max_zoom;

    [SerializeField]
    float min_zoom;

    [SerializeField]
    float speed;
    
    private Vector3 zoomScale;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //>> 코루틴으로 개선X
        //>> 매 프레임 단위로 계산해서 반응을 빠르게 해아함.
        OnPinch();
    }

    private void OnPinch()
    {
        //현재 손가락 터치의 개수가 2개가 이하일경우에는 핀치를 하지 않는다.
        if (Input.touchCount < 2)
        {
            return;
        }

        float scaleX = transform.localScale.x;
        float scaleY = transform.localScale.y;
        
        // 2개의 손가락 좌표를 받음
        Touch firstTouch = Input.GetTouch(0);
        Touch secondTouch = Input.GetTouch(1);

        // 이전 위치와 이후 위치가 달라진다면

        Vector2 firstTouchPreviousPosition = firstTouch.position - firstTouch.deltaPosition;
        Vector2 SecondTouchPreviousPosition = secondTouch.position - secondTouch.deltaPosition;

        float previousTouchDistance = (firstTouchPreviousPosition - SecondTouchPreviousPosition).magnitude;
        float currentTouchDistance = (firstTouch.position - secondTouch.position).magnitude;


        float zoomPower = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * speed * Time.deltaTime;

        if (previousTouchDistance <= currentTouchDistance)
        {
            zoomScale = new Vector3(1, 0, 0) * zoomPower;

            if (scaleX + zoomScale.x >= max_zoom)
            {
                transform.localScale = new Vector3(max_zoom, scaleY, 0);
            }
            else
            {
                transform.localScale += zoomScale;
            }
        }
        else if (previousTouchDistance > currentTouchDistance)
        {
            zoomScale = new Vector3(-1, 0, 0) * zoomPower;

            if (scaleX + zoomScale.x <= min_zoom)
            {
                transform.localScale = new Vector3(min_zoom, scaleY, 0);
            }
            else
            {
                transform.localScale += zoomScale;
            }
        }
    }
}
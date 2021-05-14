using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float moveSpeed; // 플레이어 속도 
    private Animator anim; // Animator 불러오기 위한 변수

    // Start is called before the first frame update
    void Start()
    {
        //anim 변수 선언
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //좌우 이동
        if (Input.GetAxisRaw("Horizontal")>0f || Input.GetAxisRaw("Horizontal") < 0f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        //상하 이동 
        if (Input.GetAxisRaw("Vertical") > 0f || Input.GetAxisRaw("Horizontal") < 0f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        // 애니메이션 MoveX,MoveY
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 유니티 모바일 터치 이동 구현 참고 링크
// https://www.engedi.kr/unity/?q=YToxOntzOjEyOiJrZXl3b3JkX3R5cGUiO3M6MzoiYWxsIjt9&bmode=view&idx=3955143&t=board
public class TouchMove : MonoBehaviour
{
    private float speed = 5f;
    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private Vector3 velocity;
    void Update()
    {
        if (Input.touchCount > 0)

        {
            // 터치 끝났을 때
            if (Input.GetTouch(0).phase == TouchPhase.Ended)

            {

                //Debug.Log("Ended - 손가락이 화면 위를 벗어나 떨어지게 된 그 순간, 터치가 끝난 상태: " + Input.GetTouch(0).position);
                // 왼쪽 터치 시 왼쪽으로 이동
                if (Input.GetTouch(0).position.x > (1080/2))

                {
                    velocity = new Vector3(Input.GetTouch(0).pressure, 0, 1);
                    velocity *= speed;
                    rig.velocity = velocity;

                } else
                // 오른쪽 터치 시 오른쪽으로 이동
                {
                    velocity = new Vector3(-Input.GetTouch(0).pressure, 0, 1);
                    velocity *= speed;
                    rig.velocity = velocity;
                }

            }

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Backround 이동을 하기 위한 클래스
public class Background : MonoBehaviour
{
    private float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        // PC 성능별로 문제가 생길 수 있기 때문에 마지막에 Time.deltaTime; 추가
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;

        if (transform.position.y < -10)
        {
            transform.position += new Vector3(0, 20f, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 이벤트 방법 1
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // float verticalInput = Input.GetAxisRaw("Vertical");

        // // x, y, z 2D 게임의 경우 z 값 없으니 0
        // Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0);

        // transform.position += moveTo * moveSpeed * Time.deltaTime;

        // 키보드 이벤트 방법 2
        Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= moveTo;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += moveTo;
        }
    }
}

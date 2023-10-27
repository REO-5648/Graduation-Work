using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour
{
    public float speed = 5.0f; // オブジェクトの移動速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトを前に移動させる例
        float moveX = Input.GetAxis("Horizontal"); // 水平方向の入力を取得
        float moveZ = Input.GetAxis("Vertical");   // 垂直方向の入力を取得

        Vector3 movement = new Vector3(moveX, 0.0f, moveZ); // 移動ベクトルを作成
        transform.Translate(movement * speed * Time.deltaTime); // オブジェクトを移動
    }
}

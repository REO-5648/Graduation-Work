using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour
{
    public float speed = 5.0f; // �I�u�W�F�N�g�̈ړ����x

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �I�u�W�F�N�g��O�Ɉړ��������
        float moveX = Input.GetAxis("Horizontal"); // ���������̓��͂��擾
        float moveZ = Input.GetAxis("Vertical");   // ���������̓��͂��擾

        Vector3 movement = new Vector3(moveX, 0.0f, moveZ); // �ړ��x�N�g�����쐬
        transform.Translate(movement * speed * Time.deltaTime); // �I�u�W�F�N�g���ړ�
    }
}

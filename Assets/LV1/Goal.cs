using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject clearText;    //���x�����N���A����ƕ\������e�L�X�g���i�[
    public GameObject nextButton;   //���̃��x���֑J�ڂ���{�^�����i�[
    public AudioSource audioSource;  //���y���Đ�����R���|�[�l���g

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�S�[��");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();
    }

   

}

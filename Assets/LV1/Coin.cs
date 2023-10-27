using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private string pTag = "Player";
    public GameManager gameManager;

    // Start is called before the first frame update
    private void Start()
    {
        //�܂���[�Q�[���I�u�W�F�N�g]��T���ĕϐ��ɍT���Ă���
        GameObject managerObject = GameObject.Find("GameManager");
        //�T���Ă������Q�[���I�u�W�F�N�g�ɑ΂���GetComponent��GameManager�R���|�[�l���g���擾
        gameManager = managerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == pTag) 
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }

}

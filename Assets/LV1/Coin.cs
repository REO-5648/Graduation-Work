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
        //まずは[ゲームオブジェクト]を探して変数に控えておく
        GameObject managerObject = GameObject.Find("GameManager");
        //控えておいたゲームオブジェクトに対してGetComponentでGameManagerコンポーネントを取得
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

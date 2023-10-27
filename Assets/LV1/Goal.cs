using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameObject clearText;    //レベルをクリアすると表示するテキストを格納
    public GameObject nextButton;   //次のレベルへ遷移するボタンを格納
    public AudioSource audioSource;  //音楽を再生するコンポーネント

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
        Debug.Log("ゴール");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSource.Play();
    }

   

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;

    //ゲームオーバを表示するテキスト
    private GameObject ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        // シーン中のGameOverTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.ScoreText.GetComponent<Text>().text = "Score=" + this.score.ToString("0000");

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            this.score += 30;
        }
        else if(other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 10;
        }
        else if(other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 10;
        }

    }
}

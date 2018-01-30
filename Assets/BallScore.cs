using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{


    //課題。スコア変数


    public Text scoreText;
    private int score = 10;

 // GameObject tag1 = GameObject.Find("Ball");


    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


          scoreText.text = score.ToString();
    

    }


    // ポイントの追加
    public void AddPoint(int point)
    {
        score = score + point;
    }
 


    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {



        string scoreTag = collision.gameObject.tag;

      //  Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == scoreTag)
        {
           

            if (scoreTag == "SmallStarTag")
            {
                score += 10;
            }
            else if (scoreTag == "LargeStarTag")
            {
                score += 15;
            }
            else if (scoreTag == "SmallCloudTag")
            {
                score += 20;
            }
            else if (scoreTag == "LargeCloudTAg")
            {
                score += 25;

            }
        }


    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{


    //課題。スコア変数


    public Text scoreText;
    private int score = 0;


    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


          scoreText.text = score.ToString();
    

    }




    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {



        string scoreTag = collision.gameObject.tag;



        if (collision.gameObject.tag == scoreTag)
        {
           

            if (scoreTag == "SmallStarTag")
            {
                score += 1;
            }
            else if (scoreTag == "LargeStarTag")
            {
                score += 10;
            }
            else if (scoreTag == "SmallCloudTag")
            {
                score += 20;
            }
            else if (scoreTag == "LargeCloudTAg")
            {
                score += 50;

            }
        }


    }


}

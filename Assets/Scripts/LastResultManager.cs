using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastResultManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] Text ResultText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = Score.totalScore.ToString();

        if(Score.totalScore > 1000){
            ResultText.text = "すげえええええええええええ！";
        }
        else if(Score.totalScore > 500){
            ResultText.text = "ふーん、やるじゃん";
        }
        else {
            ResultText.text = "ざーこ";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

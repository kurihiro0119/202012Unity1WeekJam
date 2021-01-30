using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager2 : MonoBehaviour
{

    [SerializeField] Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = Score.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")){
        
            SceneManager.LoadScene("Game4");
        
    }
    }
}

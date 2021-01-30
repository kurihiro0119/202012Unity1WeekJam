using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class FrameManager5: MonoBehaviour
{
    const float speed = 4;
    const int ratio = 3;
    Rigidbody2D rigidbody2D;
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject shutterText;
    [SerializeField] AudioClip shutterSE;

    int nextStage = 0;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rigidbody2D.velocity = new Vector2(speed * x, speed * y);

        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            AsyncShutter();
        }

        Debug.Log(Score.score);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Sun"){
            Score.sunFlag = true;
        }
        Debug.Log("フレームのフラグ" + Score.sunFlag);
        if(collision.gameObject.tag == "HUMAN"){
            Score.humanStatus = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        Score.sunFlag = false;
        Debug.Log("フレームのフラグ" + Score.sunFlag);

        Score.humanStatus = false;
    }

    async void AsyncShutter(){
        Debug.Log("Async Start");
        // shutterText.SetActive(true);
        audioSource.PlayOneShot(shutterSE);
        await Task.Delay(1000);
        nextStage = Score.scorePlus_human(ratio);

        if(nextStage == 0){
            SceneManager.LoadScene("Result5_good");
        }
        else if(nextStage == 1){
            SceneManager.LoadScene("Result5_low1");
        }
        if(nextStage == 2){
            SceneManager.LoadScene("Result5_low2");
        }
        if(nextStage == 3){
            SceneManager.LoadScene("Result5_bad");
        }
    }
}


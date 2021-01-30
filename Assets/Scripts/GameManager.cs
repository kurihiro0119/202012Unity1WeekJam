using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject  StartText;
    [SerializeField] GameObject  SleepingSun;
    [SerializeField] GameObject  cameraicon;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        AsynchideText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    async void AsynchideText(){
        Debug.Log("Async Start");
        await Task.Delay(1000);
        StartText.SetActive(false);
        cameraicon.SetActive(false);
        await Task.Delay(1000);
        SleepingSun.SetActive(true);
    }
}

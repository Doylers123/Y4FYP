using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{
    RoundStart roundStart;
    public float currentTime;
    public float startTime;

    [SerializeField] Text countdown;

    // Start is called before the first frame update
    void Start()
    {
        //countdown = GetComponent<Text>();
        currentTime = startTime;

    }

    

    // Update is called once per frame
    public void Update()
    {
        // deltaTime is the time in seconds it took to complete the last frame
        
        currentTime -= 1 * Time.deltaTime;
        countdown.text = currentTime.ToString("0");
        

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}

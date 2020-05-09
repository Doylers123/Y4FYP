using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RoundStart : MonoBehaviour {
    public int countdownTime;
    public GameObject countdownDisplay;

    private void Start () {

        // StartCoroutine(countdownToStart());
        StartCoroutine (startDelay ());

    }

    IEnumerator startDelay () {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3.5f;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        countdownDisplay.gameObject.SetActive (false);
        Time.timeScale = 1;
    }

}
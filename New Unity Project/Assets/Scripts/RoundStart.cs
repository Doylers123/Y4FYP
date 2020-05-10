using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RoundStart : MonoBehaviour {
    public int countdownTime;
    public GameObject countdownDisplay;

    private void Start () {
        StartCoroutine (startDelay ()); // starts the IEnumerator for startDelay();
    }

    IEnumerator startDelay () {
        Time.timeScale = 0; // freezes time
        float pauseTime = Time.realtimeSinceStartup + 3.5f; //ppauses time for 3.5 seconds
        while (Time.realtimeSinceStartup < pauseTime) // while realtimeSinceStartup is greater than the pause time
            yield return 0;
        countdownDisplay.gameObject.SetActive (false); // turns off the countdown display
        Time.timeScale = 1; //unfreezes time
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public static AudioClip hit, health, gun, coin, jump, win, draw;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start () {
        hit = Resources.Load<AudioClip> ("Hit"); // Loads clip named "Hit"
        health = Resources.Load<AudioClip> ("Health"); // Loads clip named "Health"
        gun = Resources.Load<AudioClip> ("Gun"); // Loads clip named "Gun"
        coin = Resources.Load<AudioClip> ("Coin"); // Loads clip named "Coin"
        jump = Resources.Load<AudioClip> ("Jump"); // Loads clip named "Jump"
        win = Resources.Load<AudioClip> ("Win"); // Loads clip named "Win"
        draw = Resources.Load<AudioClip> ("Draw"); // Loads clip named "Draw"

        audioSource = GetComponent<AudioSource> (); //gets the audio source
    }

    // Update is called once per frame
    public static void PlaySound (string clip) {
        switch (clip) {
            case "Hit":
                audioSource.PlayOneShot (hit); // if its hit, plays hit sound
                break;
            case "Health":
                audioSource.PlayOneShot (health);// if its health, plays health sound
                break;
            case "Gun":
                audioSource.PlayOneShot (gun);// if its gun, plays gun sound
                break;
            case "Coin":
                audioSource.PlayOneShot (coin);// if its coin, plays coin sound
                break;
            case "Jump":
                audioSource.PlayOneShot (jump);// if its jump, plays jump sound
                break;
            case "Win":
                audioSource.PlayOneShot (win);// if its win, plays win sound
                break;
            case "Draw":
                audioSource.PlayOneShot (draw);// if its draw, plays draw sound
                break;
            default:
                break;

        }
    }
}
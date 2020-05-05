using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip hit, health, gun, coin, jump, win, draw;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        hit = Resources.Load<AudioClip> ("Hit");
        health = Resources.Load<AudioClip> ("Health");
        gun = Resources.Load<AudioClip> ("Gun");
        coin = Resources.Load<AudioClip> ("Coin");
        jump = Resources.Load<AudioClip> ("Jump");
        win = Resources.Load<AudioClip> ("Win");
        draw = Resources.Load<AudioClip> ("Draw");
        


        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Hit":
            audioSource.PlayOneShot (hit);
            break;
            case "Health":
            audioSource.PlayOneShot (health);
            break;
            case "Gun":
            audioSource.PlayOneShot (gun);
            break;
            case "Coin":
            audioSource.PlayOneShot (coin);
            break;
            case "Jump":
            audioSource.PlayOneShot (jump);
            break;
            case "Win":
            audioSource.PlayOneShot (win);
            break;
            case "Draw":
            audioSource.PlayOneShot (draw);
            break;
            default:
            break;


        }   
    }
}
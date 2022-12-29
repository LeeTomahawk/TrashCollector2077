using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "trash1")
        {
            var sc = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("score", sc += 10);
            Destroy(other.gameObject);
            audio.Play();
        }
        else if(other.gameObject.tag == "trash2")
        {
            var sc = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("score", sc += 12);
            Destroy(other.gameObject);
            audio.Play();
        }
        else if (other.gameObject.tag == "trash3")
        {
            var sc = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("score", sc += 14);
            Destroy(other.gameObject);
            audio.Play();
        }
        else if (other.gameObject.tag == "trash4")
        {
            var sc = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("score", sc += 16);
            Destroy(other.gameObject);
            audio.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.tag == "battery" || other.tag == "walkie" || other.tag == "firstaid")
        {
            Debug.Log("kolizja");
            var sc = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("score", sc += 1);
            // Usuniêcie obiektu po kolizji z graczem
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefreshScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //tutaj mozna dane pozycji gracza ustawic
        GameObject.Find("PlayerCapsule").transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
        GameObject.Find("PlayerFollowCamera").transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
    }

    // Update is called once per frame
    void Update()
    {
        var obj = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        obj.text = PlayerPrefs.GetInt("score").ToString();
    }
}

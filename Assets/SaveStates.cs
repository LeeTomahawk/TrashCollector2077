using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using Assets;
using Newtonsoft.Json;
using TMPro;
using StarterAssets;

public class SaveStates : MonoBehaviour
{
    public string savePath = "C:\\TrashCollector2077";
    public string saveFilename = "Save.txt";

    public string scoreText;
    public bool isModalVisible = false;
    public GameObject modal;
   
    //time
    //playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        modal = GameObject.Find("MenuModal");
        modal.SetActive(false);

        //ustawienie danych gracza tutaj z PlayerPrefs
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "ParkGameScene")
        {
            SetDisplayModal();
        }
    }

    void SetDisplayModal()
    {
        isModalVisible = !isModalVisible;
        modal.SetActive(isModalVisible);
        StarterAssetsInputs.SetCursorInputForLook(!isModalVisible);
    }

    public void LoadGame()
    {
        var fileName = Path.Combine(savePath, saveFilename);
        if (File.Exists(fileName))
        {
            var data = JsonConvert.DeserializeObject<PlayerData>(File.ReadAllText(fileName));
            //uzuplenienie danych
            PlayerPrefs.SetInt("score", data.Score);
            PlayerPrefs.SetFloat("x", data.X);
            PlayerPrefs.SetFloat("y", data.Y);
            PlayerPrefs.SetFloat("z", data.Z);
            //tutaj pozostale dane

            SceneManager.LoadScene("ParkGameScene");
            StarterAssetsInputs.SetCursorInputForLook(true);
        }
    }
}

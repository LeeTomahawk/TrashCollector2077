using Assets;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using StarterAssets;

public class ModalActions : MonoBehaviour
{
    public string savePath = "C:\\TrashCollector2077";
    public string saveFilename = "Save.txt";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetFloat("x", 3.97f);
        PlayerPrefs.SetFloat("y", 0.18f);
        PlayerPrefs.SetFloat("z", -14.95f);
        StarterAssetsInputs.SetCursorInputForLook(true);
        SceneManager.LoadScene("ParkGameScene");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SaveGame()
    {
        if (!Directory.Exists(savePath))
        {
            Directory.CreateDirectory(savePath);
        }

        if (File.Exists(Path.Combine(savePath, saveFilename)))
        {
            File.Delete((Path.Combine(savePath, saveFilename)));
        }
        var playerData = GameObject.Find("PlayerCapsule").transform.position;

        var writer = new StreamWriter((Path.Combine(savePath, saveFilename)));
        writer.Write(JsonConvert.SerializeObject(new PlayerData
        {
            Score = PlayerPrefs.GetInt("score"),
            X = playerData.x,
            Y = playerData.y,
            Z = playerData.z
        }));
        writer.Close();

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

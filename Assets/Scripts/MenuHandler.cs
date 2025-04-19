using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{

    [SerializeField] private PlayerInputManager playerInputManager;

    // Start is called before the first frame update
    void Start()
    {
        if (playerInputManager != null) {

            DataManager.Instance.LoadPlayerData();
            playerInputManager.SetPlayerHighestScore();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() {

        SceneManager.LoadScene(1,LoadSceneMode.Single);

        if (playerInputManager != null) {

            playerInputManager.SetPlayerName();

        }

        //Debug.Log(DataManager.Instance.playerName);

    }

    public void BackToMenu() {

        SceneManager.LoadScene(0, LoadSceneMode.Single);

    }

    public void ExitGame() {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }


}

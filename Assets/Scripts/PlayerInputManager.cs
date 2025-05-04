using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//INHERITANCE
public class PlayerInputManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI playerNameField;
    [SerializeField] private TextMeshProUGUI PlayerBestScoreString;

    private string playerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName() {

        

        if (!string.IsNullOrWhiteSpace(playerNameField.text)) {

            playerName = playerNameField.text;
            DataManager.Instance.playerName = playerName;

        }

    }

    public void SetPlayerHighestScore() {

        PlayerBestScoreString.text = DataManager.Instance.bestScoreText;

    }
}

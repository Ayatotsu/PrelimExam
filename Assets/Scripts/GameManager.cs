using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float score;
    public string levelName; //this is used for tracking or identifying what game mode or level the player is
    public TextMeshProUGUI timeMessage;
    

    void Start()
    {
        
    }
    void Update()
    {
        score = score += Time.deltaTime;
    }


    
    public void Quit()
    {
        Application.Quit();
        Debug.Log("GameQuit!");
    }


}

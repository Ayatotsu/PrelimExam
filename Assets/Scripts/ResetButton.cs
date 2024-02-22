using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResetButton : MonoBehaviour
{
    [SerializeField] public string whatScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame() 
    {
        SceneManager.LoadScene(whatScene);
        Time.timeScale = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceLevelEnd : MonoBehaviour
{
    
    public int gameStartSceneWin;
    public int gameStartSceneLose;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("You finished the level");
           
            SceneManager.LoadScene(gameStartSceneWin);

        }

       
    }
}

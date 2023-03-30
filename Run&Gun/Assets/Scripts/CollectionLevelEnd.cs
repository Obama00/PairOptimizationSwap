using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectionLevelEnd : MonoBehaviour
{
    public int requiredCoins;
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
        if(collision.CompareTag("Player") && Coin.totalCoins >= requiredCoins)
        {
            Debug.Log("You finished the level");
           
            SceneManager.LoadScene(gameStartSceneWin);

        }

        if (collision.CompareTag("Player") && Coin.totalCoins < requiredCoins)
        {
            Debug.Log("You finished the level");
          
            SceneManager.LoadScene(gameStartSceneLose);
           
        }
    }
}

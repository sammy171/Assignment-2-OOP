using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Score : MonoBehaviour
{
    public Text countText;
   // public static int currentLevel = 0;
    private bool gameover =  false;
    private int count;

    #region Singleton
    // This makes a class act as a "Singleton"
    public static Score Instance = null;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public void AddScore(int scoreToAdd)
    {
        count += scoreToAdd;
    }

    void Start()
    {
        count = 0;
    }

    private void Update()
    {
        CountText();
    }

    void CountText()
    {
        countText.text = "Count: " + count.ToString();
        // when the score hits a certain amount - end game and restart scene
        if(count >= 20)
        {
            gameover = true;
            if(gameover == true)
            {
                SceneManager.LoadScene("Scene 1");
            }
        }
    }

    




}

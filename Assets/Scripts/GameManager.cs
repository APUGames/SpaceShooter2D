using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Net.Http.Headers;

public class GameManager : MonoBehaviour
{
    // This script will handle the game's state

    public static GameManager Instance { get; private set; }

    private bool playerWon = false;
    private bool playerDead = false;

    private int playerPoints = 0;
    public int count = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(Instance);
    }

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "Lost Screen")
        {
            count = 5001;
        }

        if (count == 5000)
            {
                SceneManager.LoadScene("End Screen");
            }
            else
            {
                count++;
            }
    }

    public void SetPlayerDead()
    {
        playerDead = true;
    }

    public void SetPlayerPoints(int points)
    {
        playerPoints += points;
    }

    public void SetPlayerWon(bool won)
    {
        playerWon = won;
    }

    public bool GetPlayerDead()
    {
        return playerDead;
    }

    public bool GetPlayerWon()
    {
        return playerWon;
    }

    public int GetPlayerPoints()
    {
        return playerPoints;
    }
}
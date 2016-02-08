using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject panelPause;
    public Text playerName;
    public enum GameState { menu, pause, playing, endOfGame, beforePlay };

    public GameObject CanvasEndGameWin;
    public GameObject CanvasEndGameLoose;

    public GameState gamestate;
    #region Singleton
    static private GameManager s_Instance;
    #endregion
    static public GameManager instance
    {
        get
        {
            return s_Instance;
        }
    }
    void Awake()
    {
        if (s_Instance == null)
            s_Instance = this;
        gamestate = GameState.menu;
    }

    void OnLevelWasLoaded(int level)
    {

    }

    void Update()
    {
        if (GameManager.instance.gamestate == GameManager.GameState.pause)
        {
            //panelPause.SetActive(true);
        }
        else
        {
            //panelPause.SetActive(false);
        }
    }





    public void GameOver()
    {
        Debug.Log("Loose");
    }


}
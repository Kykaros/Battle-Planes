using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public static int Score;
    public static int dem = 0;
    public static int HighScore = 0;
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        Score = 0;
        HighScore = PlayerPrefs.GetInt(controlplayer.User);
	}
	
	// Update is called once per frame
	void Update () {
        //if (controlplayer.Death == true)
        //    reset();
        //if (controlplayer.GameOver == true)
        //{
        //    Debug.Log("Save Score");
        //    SaveHighScore(controlplayer.User, Score);
        //}
        text.text = "" + Score;
	}
    public static void addpoint(int p)
    {
        Score += p;
    }
    public static void reset()
    {
        Score = 0;
    }
    public static void SaveHighScore(string UserName, int Value)
    {
        if(Score > HighScore)
        {
            PlayerPrefs.SetInt(UserName, Value);
        }
    }
    public static void addtime(int p)
    {
        dem += p;
        if(dem==1000)
        {
            health.congtime();
            dem = 0;
        }
    }
}
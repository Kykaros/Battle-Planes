using UnityEngine;
using System.Collections;

public class Reborn : MonoBehaviour {
    public int level;
    public GameObject Player;
    public Vector3 pos;
    void Start () {
        Instantiate(Player, pos, transform.rotation);
        Debug.Log("New Player has been created");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (controlplayer.Death == true)
        {
            if (health.Health > 0)
            {
                StartCoroutine(Delay());
                controlplayer.Death = false;
                Debug.Log("tao lai Player");
            }
            else
            {
                controlplayer.Death = false;
                controlplayer.GameOver = true;
                Debug.Log("Game Over");
                score.SaveHighScore(controlplayer.User, score.Score);
                //Menu.GameOver(3);
                Application.LoadLevel(1);
            }
        }
    }
    /*public void GameOver()
    {
        //Menu.ScenceGameOver();
        Application.LoadLevel(2);
    }*/
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Instantiate(Player, pos, transform.rotation);
    }
}

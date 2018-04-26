using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Notifi : MonoBehaviour
{
    public Text WinText;
    public int Round = 1;
	// Use this for initialization
	void Start () {
        WinText.text = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(bosscontrol.Death==true)
        {
            WinText.text = "Mission Complete !";
            StartCoroutine(Delay());
        }
	}
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        WinText.text = "";
        bosscontrol.Death = false;
        //Menu.LevelMap("levelmap");
    }
}

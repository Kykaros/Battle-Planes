using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    Text HighSc;
    int Temp;
	// Use this for initialization
	void Start () {
        HighSc = GetComponent<Text>();
        Temp = PlayerPrefs.GetInt(controlplayer.User);
        HighSc.text = Temp.ToString();
        Debug.Log(Temp);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

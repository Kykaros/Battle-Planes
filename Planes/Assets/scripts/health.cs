using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class health : MonoBehaviour {
    public static int Health;
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        Health = 3;
	}
	// Update is called once per frame
	void Update () {
        if (Health < 0)
            Health = 0;
        text.text = Health + "X";	
	}
    public static void trutime()
    {
        Health--;
    }
    public static void congtime()
    {
        Health++;
    }
    public void reset()
    {
        Health = 0;
    }
}
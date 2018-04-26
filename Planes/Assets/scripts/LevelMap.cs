using UnityEngine;
using System.Collections;

public class LevelMap : MonoBehaviour {
    public static bool Win=false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(bosscontrol.Death==true)
        {
            Win = true;
        }
	}

}

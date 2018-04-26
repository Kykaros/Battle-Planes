using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetScore : MonoBehaviour {
    Text Target;
	// Use this for initialization
	void Start () {
        Target = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Target.text = spawn.NextScore.ToString();
    }
}

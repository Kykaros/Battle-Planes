using UnityEngine;
using System.Collections;

public class bigbang : MonoBehaviour {
    public float time = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.zero);
        Destroy(this.gameObject, time);
    }
}

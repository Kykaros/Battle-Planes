using UnityEngine;
using System.Collections;

public class ScrollBG : MonoBehaviour {
    public float Scrollspeed;
    public float tileSizeZ;
    private Vector3 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float newposition = Mathf.Repeat(Time.time * Scrollspeed, tileSizeZ);
        transform.position = startPosition + Vector3.up * newposition;
	}
}

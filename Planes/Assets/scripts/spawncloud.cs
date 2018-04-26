using UnityEngine;
using System.Collections;

public class spawncloud : MonoBehaviour {
    public float cloudbegin;
    public float clouddeplay;
    public GameObject cloud;
	// Use this for initialization
	void Start () {
        cloudbegin = Random.Range(4f, 8f);
        clouddeplay = Random.Range(4f, 8f);
        InvokeRepeating("spawnclound", cloudbegin, clouddeplay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void spawnclound()
    {
        Instantiate(cloud, transform.position, transform.rotation);
    }
}

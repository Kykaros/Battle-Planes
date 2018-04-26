using UnityEngine;
using System.Collections;

public class clound2 : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y<-9)
            Destroy(this.gameObject);
    }
}

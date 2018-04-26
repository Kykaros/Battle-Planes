using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
    public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if(transform.position.y>8.0)
        {
            Destroy(this.gameObject);
        }
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy1")
        {
            Destroy(this.gameObject);
        }
        if(coll.gameObject.tag=="boss")
        {
            Destroy(this.gameObject);
        }
    }
}
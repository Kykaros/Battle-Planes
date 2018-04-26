using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    private int pointadd=10;
    private float speed = 5;
    public GameObject bang;
    public GameObject coin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if(transform.position.y<-8.5)
        {
            Destroy(this.gameObject);
        }
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "fire")
        {
            Destroy(this.gameObject);
            Instantiate(bang, transform.position, Quaternion.identity);
                score.addpoint(pointadd);
                score.addtime(pointadd);
            Instantiate(coin, transform.position, Quaternion.identity);
        }
        if(coll.gameObject.tag =="Player")
        {
            Destroy(this.gameObject);
            Instantiate(bang, transform.position, Quaternion.identity);
        }
    }
}
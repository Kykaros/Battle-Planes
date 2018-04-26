using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    public static int C;
    public float Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.down * Speed * Time.deltaTime);
        if(transform.position.y <= -9.25)
        {
            Destroy(this.gameObject);
        }
	}
    void OnTriggerEnter2D(Collider2D Ob)
    {
        if(Ob.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            AddCoin();
        }
    }
    public static void AddCoin()
    {
        C++;
    }
    public static void ResetCoin()
    {
        C = 0;
    }
}

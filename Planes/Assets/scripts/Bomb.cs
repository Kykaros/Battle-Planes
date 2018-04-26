using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
    public float Speed;
    // Use this for initialization
    void Start()
    {
    }
    void Update()
    {
        transform.Translate(Vector3.up *Speed* Time.deltaTime);
        if(transform.position.y<-9.4)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}

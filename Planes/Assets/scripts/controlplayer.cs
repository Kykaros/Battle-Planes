using UnityEngine;
using System.Collections;

public class controlplayer : Player
{
    // Use this for initialization
    void Start ()
    {
        this.GetComponent<SpriteRenderer>().sprite = Mid;
	}

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        if (Input.GetKey("a") && transform.position.x > -8.5)
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            this.GetComponent<SpriteRenderer>().sprite = LeftSide;
        }
        else if (Input.GetKey("d") && transform.position.x < 8.45)
        {
            this.transform.Translate(Vector3.right * Speed * Time.deltaTime);
            this.GetComponent<SpriteRenderer>().sprite = RightSide;
        }
        else if (Input.GetKey("w") && transform.position.y < 6.3)
        {
            this.transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        else if (Input.GetKey("s") && transform.position.y > -6.30)
        {
            this.transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
        else if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            this.GetComponent<SpriteRenderer>().sprite = Mid;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = Mid;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Shoot();
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag=="enemy1")
        {
            PlayerDie();
            Debug.Log("Player va cham voi dich");
        }
        if(coll.gameObject.tag=="Bullet_Boss")
        {
            PlayerDie();
            Debug.Log("player trung dan cua boss");
        }
    }
}
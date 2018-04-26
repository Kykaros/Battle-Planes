using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static string User = "Player";
    public int Health = 3;
    public float Speed;
    public GameObject fire;
    public GameObject bang;
    public static bool Death = false;
    public Sprite LeftSide;
    public Sprite RightSide;
    public Sprite Mid;
    public static bool GameOver = false;
    public static Vector3 PosPlayer;
    public Animation Flyer;

    public void PlayerDie()
    {
        Destroy(this.gameObject);
        Instantiate(bang, transform.position, Quaternion.identity);
        Death = true;
        health.trutime();
    }
    public void Shoot()
    {
        Instantiate(fire, transform.position, Quaternion.identity);
    }
}

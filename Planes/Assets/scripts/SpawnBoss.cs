using UnityEngine;
using System.Collections;

public class SpawnBoss : MonoBehaviour {
    public Vector3 pos;
    public GameObject Boss_1;
    int NextSpawnPoint = 150;
    bool Iscall = false;
    //public GameObject[] ArrBoss;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(score.Score == NextSpawnPoint && Iscall == false) //dieu kien de ko spawn nhieu boss
        {
            /*for(int i =0;i<ArrBoss.Length;i++)
            {
                Instantiate(ArrBoss[i], pos, transform.rotation);
            }*/
            Boss_1_Awake();
            Iscall = true;
            NextSpawnPoint += 150;
        }
        else if(bosscontrol.Death == true)
        {
            Iscall = false;
        }
	}
    void Boss_1_Awake()
    {
        Instantiate(Boss_1, pos, transform.rotation);
    }
}
using UnityEngine;
using System.Collections;

public class Boss_Shoot : MonoBehaviour {
    public GameObject Bullet;
    int count = 0;
    private bool FinishWait = false;
	// Use this for initialization
	void Start () {
        StartCoroutine(Waiting());
	}
	
	// Update is called once per frame
	void Update () {
        if(FinishWait==false)
        {
            StartCoroutine(Waiting());
        }
        else
        {
            count++;
            if (count >= 60 && FinishWait == true)
            {
                StartCoroutine(Shoot());
                count = 0;
            }
        }
	}
    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(2.5f);
        Instantiate(Bullet, transform.position, transform.rotation);
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(7f);
        FinishWait = true;
    }
}

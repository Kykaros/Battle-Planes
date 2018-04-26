using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
    public float enemybegin=0;
    public float enemydeplay;
    public GameObject Enemy;
    public static int NextScore = 150;
    private bool IsCancle = false;
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnenemy", enemybegin, enemydeplay);
	}

    // Update is called once per frame
    int Dem = 1;
	void Update ()
    {
        if (score.Score == NextScore && IsCancle == false)
        {
            Debug.Log("Have Cancle !" +Dem);
            Dem++;
            CancelInvoke("spawnenemy");
            IsCancle = true;
            NextScore += 150;
        }
        else if(bosscontrol.Death == true && IsCancle == true)
        {
            Debug.Log("Have continue");
            StartCoroutine(Delay());
            InvokeRepeating("spawnenemy", enemybegin, enemydeplay);
            IsCancle = false;
            //bosscontrol.Death = false;
        }
	}
    void spawnenemy()
    {
        float x = Random.Range(-9.45f, 9.99f);
        Instantiate(Enemy, new Vector3(x, 13.66f, 0), transform.rotation);
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    }
}

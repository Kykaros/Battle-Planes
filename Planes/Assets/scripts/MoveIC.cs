using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveIC : MonoBehaviour {
    public GameObject[] Desti;
    private Vector3 Target;
    private Vector3 Target_rot;
    int NextP = 0;
    //bool HaveArr = false;
    int CurrentPosition;
    private float speed = 0.4f;
	// Use this for initialization
	void Start () {
        for(int i=0;i<6;i++)
        {
            Desti[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(LevelMap.Win==true)
        {
            GameObject Temp = NextPoint(NextP);
            OpenNewPoint(Temp);
            Move(Temp);
        }
    }
    GameObject NextPoint(int Next)
    {
        int Temp = Next;
        Next++;
        return Desti[Temp];
    }
    void Move(GameObject Point)
    {
        Target = Point.transform.position;
        Target.z = transform.position.z;
        Target_rot = Point.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, Target, speed * Time.deltaTime);
        var Angle = Mathf.Atan2(Target_rot.y - transform.position.y, Target_rot.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, Angle - 90);
        //transform.Rotate(0, 0, -20 * Time.deltaTime);
       // transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    void OpenNewPoint(GameObject P)
    {
        P.SetActive(true);
    }
}

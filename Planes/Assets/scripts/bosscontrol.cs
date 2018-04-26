using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class bosscontrol : MonoBehaviour
{
    public static bool Death = false;
    public float Second=6.0f;
    public int HP = 10;
    private int CurrentHealth;
    public float speed;
    bool isleft = false;
    bool PlaySound = false;
    public GameObject Bullet;
    public GameObject Bomb;
    public GameObject Bang;
    int count = 0;
    //public Slider BossHealthSlider;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Waitfor3s());
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 4.65 && PlaySound==true)
        {
            transform.Translate(Vector3.down * 4 * Time.deltaTime);
        }
        if (transform.position.y < 4.65)
        {
            count++;
            if (transform.position.x > -3.35 && isleft == false)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                if (transform.position.x < -3.35)
                    isleft = true;
            }
            else
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                if (transform.position.x > 3.38)
                {
                    isleft = false;
                }
            }
            /*if(HP==5)
            {
                Instantiate(Bomb, transform.position, transform.rotation);
            }*/
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "fire")
        {
            HP--;
           // BossHealthSlider.value = CurrentHealth;
            StartCoroutine(ChangeColor());
            if (HP <= 0)
            {
                Destroy(this.gameObject);
                Instantiate(Bang, transform.position, Quaternion.identity);
                Death = true;
                //Menu.LevelMap("levelmap");
            }
        }
    }
    IEnumerator ChangeColor()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.2f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
    IEnumerator Waitfor3s()
    {
        yield return new WaitForSeconds(Second);
        PlaySound = true;
    }
    IEnumerator DelayForSecond(float s)
    {
        Debug.Log("Wait in BossC");
        yield return new WaitForSeconds(s);
    }
}
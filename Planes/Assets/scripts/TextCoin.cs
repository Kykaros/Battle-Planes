using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class TextCoin : MonoBehaviour {
    // Use this for initialization
    private static int C;
    Text CoinPoint;
	void Start () {
        CoinPoint = GetComponent<Text>();
        C = Coin.C;
	}
	
	// Update is called once per frame
	void Update () {
        C = Coin.C;
        CoinPoint.text = "" + C;
	}
}

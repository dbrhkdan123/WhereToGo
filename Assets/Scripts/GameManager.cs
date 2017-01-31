using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int money = 1000;
    public int[] item = new int[10];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RefreshMoney(int m)
    {
        money -= m;

        Debug.Log("RefreshMoney : " + money);
    }
}

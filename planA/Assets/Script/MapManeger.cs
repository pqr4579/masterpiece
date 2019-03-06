using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManeger : MonoBehaviour {
    public GameObject end_point;
    public int timeLimit;
    public Text limitText;
    int t;
	// Use this for initialization
	void Start () {
        string a = timeLimit.ToString();
        limitText.text = a;
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            if(t>=0)
            {
                Destroy(end_point.gameObject);
                Debug.Log("실패하셨습니다.");
            }
            else
            {
                Debug.Log("성공하셨습니다");
            }
        }
    }

    // Update is called once per frame
    void Update () {
        t = timeLimit - (int)Time.time;
        limitText.text = "구출 시간" + t.ToString();

	}
}

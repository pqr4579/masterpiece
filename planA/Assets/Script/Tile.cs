using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public Vector2 point;
    public int build_able;

    private void Awake()
    {

    }
    // Use this for initialization
    void Start () {
        point = this.gameObject.transform.position;
        build_able = 0;//건설 가능 지역


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

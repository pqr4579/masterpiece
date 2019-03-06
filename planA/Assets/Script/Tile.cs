using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public Vector2 point;
    public int build_able;
    public Color can = Color.green;
    public Color cant = Color.red;
    public Color end = Color.black;
    public Color start = Color.white;
    private bool visible = false;


    private void Awake()
    {

    }
    // Use this for initialization
    void Start () {
        point.x = this.gameObject.transform.position.x;
        point.y = this.gameObject.transform.position.z;
        build_able = 0;//건설 가능 지역


	}
	public void visible_tile()
    {

    }
	// Update is called once per frame
	void Update () {
		
	}
}

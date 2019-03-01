using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int sizeX = 1;
    public int sizeY = 1;
    public List<Tile> mapsize = new List<Tile>();
    public Tile tile;
    public Transform _Map;
    public GameObject S_point;
    public GameObject E_point;
    // Use this for initialization
    private void makingMap()
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
       
                Tile _Tile = Instantiate(tile) as Tile;
                _Tile.transform.position = new Vector3(10 * j, 0, 10*i);
                _Tile.transform.parent = _Map;
                mapsize.Add(_Tile);
            }
        }
        int a = Random.Range(0, sizeX);
        int b = Random.Range(0, sizeY);
        GameObject p = Instantiate(S_point) as GameObject;
        p.transform.position = new Vector3(a*10, 3, b*10);
        GameObject e_p = Instantiate(E_point) as GameObject;
        a = Random.Range(0, sizeX);
        b = Random.Range(0, sizeY);
        e_p.transform.position = new Vector3(a*10, 3, b*10);
    }

    private void makingRandomTower()
    {

    }

    public void RandomTower()
    {

    }
    private void Awake()
    {
    }
    void Start ()
    {
        makingMap();
	}	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int sizeX = 1;
    public int sizeY = 1;
    public List<Tile> mapsize = new List<Tile>();
    public Tile tile;
    public Transform _Map;
    // Use this for initialization
    private void makingMap()
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
       
                Tile _Tile = Instantiate(tile) as Tile;
                _Tile.transform.localPosition = new Vector3(11 * j, 0, 11*i);
                _Tile.transform.parent = _Map;
                mapsize.Add(_Tile);

            }
        }
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

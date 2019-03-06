using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {

    public int sizeX = 1;
    public int sizeY = 1;
    List<List<Tile>> mapsize = new List<List<Tile>>();
    public Tile tile;
    public Transform _Map;
    public GameObject S_point;
    public GameObject E_point;
    // Use this for initialization
    private void makingMap()
    {
        if(sizeX==sizeY)//맵이 정사각형일경우
        {
            for (int i = 0; i < sizeY; i++)
            {
                mapsize.Add(new List<Tile>());
                for (int j = 0; j < sizeX; j++)
                {
                    
                    Tile _Tile = Instantiate(tile) as Tile;
                    _Tile.transform.position = new Vector3(10 * j, 0, 10 * i);
                    _Tile.transform.parent = _Map;
                    if ((j == sizeX / 2 && i == 0))
                    {
                        GameObject p = Instantiate(S_point) as GameObject;
                        p.transform.parent = _Tile.transform;
                        p.transform.localPosition = new Vector3(0, 0, 0);



                    }
                    if (j == sizeX / 2 && i == sizeY-1)
                    {
                        GameObject e_p = Instantiate(E_point) as GameObject;
                        e_p.transform.parent = _Tile.transform;
                        e_p.transform.localPosition = new Vector3(0, 0, 0);

                    }

                    mapsize[i].Add(_Tile);
                }
            }
        }
        else//직사각형일 경우
        {
            for (int i = 0; i < sizeY; i++)
            {
                mapsize.Add(new List<Tile>());
                for (int j = 0; j < sizeX; j++)
                {
                    Tile _Tile = Instantiate(tile) as Tile;
                    _Tile.transform.position = new Vector3(10 * j, 0, 10 * i);
                    _Tile.transform.parent = _Map;
                    if (i == 0 && j==sizeX/2)
                    {
                        GameObject p = Instantiate(S_point) as GameObject;
                        p.transform.parent = _Tile.transform;
                        p.transform.localPosition = new Vector3(0, 0, 0);


                    }
                    if (i==sizeY-1 && j==sizeX/2)
                    {
                        GameObject e_p = Instantiate(E_point) as GameObject;
                        e_p.transform.parent = _Tile.transform;
                        e_p.transform.localPosition = new Vector3(0, 0, 0);

                    }
                    mapsize[i].Add(_Tile);
                }
            }

        }

        /*        int a = Random.Range(0, sizeX)*10;
                int b = Random.Range(0, sizeY)*10;
                GameObject p = Instantiate(S_point) as GameObject;
                p.transform.position = new Vector3(a, 3, b);
                Tile c = findTile(a + b * sizeY);
                c.build_able = 3;
                MaterialPropertyBlock props = new MaterialPropertyBlock();
                GameObject e_p = Instantiate(E_point) as GameObject;
                a = Random.Range(0, sizeX);
                b = Random.Range(0, sizeY);
                e_p.transform.position = new Vector3(a, 3, b);
                c = findTile(a + b * sizeY);
                c.build_able = 3;
                */



    }
    public Tile findTile(int i,int j)
    {
       return mapsize[i][j];
    }

    private void makingRandomTower()
    {

    }

    public void RandomTower()
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScale : MonoBehaviour
{
    public int length = 10;
    public int width = 10;

    public GameObject floor;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    public GameObject markerFab;
	void Start ()
    {
        floor.transform.localScale = new Vector3(length / 10, 1, length / 10);
        wall1.transform.localScale = new Vector3(1, 3, length);
        wall1.transform.position = new Vector3((length / 2) + .5f, 1.5f, 0);
        wall2.transform.localScale = new Vector3(1, 3, length);
        wall2.transform.position = new Vector3(-((length / 2) + .5f), 1.5f, 0);
        wall3.transform.localScale = new Vector3(1, 3, width);
        wall3.transform.position = new Vector3(0, 1.5f, (width / 2) + .5f);
        wall4.transform.localScale = new Vector3(1, 3, width);
        wall4.transform.position = new Vector3(0, 1.5f, -((width / 2) + .5f));

        GameObject go = (GameObject)Instantiate(markerFab, new Vector3(length/3, 0, width/3), Quaternion.identity);
        go.transform.SetParent(this.transform);
    }
	void Update ()
    {
		
	}
}

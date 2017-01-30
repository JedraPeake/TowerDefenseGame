using UnityEngine;
using System.Collections;



public class waypoints : MonoBehaviour {

    public static Transform[] points;


	// Use this for initialization
	void Awake () {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++) {
            points[i] = transform.GetChild(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

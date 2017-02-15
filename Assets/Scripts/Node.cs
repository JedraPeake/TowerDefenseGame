using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
    public Vector3 positionOffset;

    void OnMouseEnter() {
        rend.material.color = hoverColor;
    }

    void OnMouseDown() {
        if (turret != null) {
            Debug.Log("Can't build there- TODO DISPLAY ON SCREEN");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    // Use this for initialization
    void Start () {
        rend = GetComponent < Renderer >();
        startColor = rend.material.color;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

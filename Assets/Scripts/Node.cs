using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class Node : MonoBehaviour {

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
    public Vector3 positionOffset;

    BuildManager buildmanager;

    void OnMouseEnter() {
        if (EventSystem.current.IsPointerOverGameObject()) {
            return;
        }
        if (buildmanager.GetTurretToBuild() == null)
        {
            return;
        }
        rend.material.color = hoverColor;
    }

    void OnMouseDown() {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (buildmanager.GetTurretToBuild() == null) {
            return;
        }
        if (turret != null) {
            Debug.Log("Can't build there- TODO DISPLAY ON SCREEN");
            return;
        }

        GameObject turretToBuild = buildmanager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    // Use this for initialization
    void Start () {
        buildmanager = BuildManager.instance;
        rend = GetComponent < Renderer >();
        startColor = rend.material.color;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

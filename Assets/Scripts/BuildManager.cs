using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour {

    private GameObject turretToBuild;
    public static BuildManager instance;
    public GameObject standardTurretPrefab;

    void Awake() {
        if (instance != null) {
            Debug.LogError("More then one build manager");
        }
        instance = this;

    }

    public GameObject GetTurretToBuild() {
        return turretToBuild;
    }

	// Use this for initialization
	void Start () {
       // turretToBuild = standardTurretPrefab;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetTurretoBuild(GameObject turret) {
        turretToBuild = turret;
    }
}

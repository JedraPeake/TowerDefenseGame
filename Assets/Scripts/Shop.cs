using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {

    BuildManager buildmanager;

    public void PurchaseStanardTurret() {
        Debug.Log("Standard Turret Selected");
        buildmanager.SetTurretoBuild(buildmanager.standardTurretPrefab);
    }

    public void PurchaseMissleLauncher()
    {
        Debug.Log("Missle Launcher Selected");
        buildmanager.SetTurretoBuild(buildmanager.missileLauncherPrefab);
    }

    // Use this for initialization
    void Start () {
        buildmanager = BuildManager.instance;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

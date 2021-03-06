﻿using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	private TurretBlueprint turretToBuild;

	public bool CanBuild { get { return turretToBuild != null; } }

	public void BuildTurretOn(Node node)
	{
		if (PlayerController.currentMoney < turretToBuild.cost)
		{
			Debug.Log("Not enough money to build that!");
			return;
		}

		PlayerController.currentMoney -= turretToBuild.cost;

		GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
		node.turret = turret;

		Debug.Log("Turret build! Money left: " + PlayerController.currentMoney);
	}

	public void SelectTurretToBuild(TurretBlueprint turret)
	{
		turretToBuild = turret;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WorldLocation : MonoBehaviour 
{
	public int area;

	public GameObject West;
	public GameObject North;
	public GameObject East;
	public GameObject South;

	public bool bWest;
	public bool bNorth;
	public bool bEast;
	public bool bSouth;
	public bool bUp;
	public bool bDown;

	public TextMeshProUGUI description;
	public TextMeshProUGUI short_description;
	public TextMeshProUGUI secrete_description;

	public enum EnviroHazardLevel
	{
		Level0,
		Level1,
		Level2,
		Level3,
		Level4,
	};
	public EnviroHazardLevel hazardLevel = EnviroHazardLevel.Level0;

	void Start () 
	{
		
	}
	
}

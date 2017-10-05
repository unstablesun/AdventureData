using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CreatureEntry : MonoBehaviour 
{
	public int id;

	public bool bWest;
	public bool bNorth;
	public bool bEast;
	public bool bSouth;

	public TextMeshProUGUI description;
	public TextMeshProUGUI short_description;
	public TextMeshProUGUI attack_description;

	public enum CreatureLevel
	{
		Level0,
		Level1,
		Level2,
		Level3,
		Level4,
	};
	public CreatureLevel creatureLevel = CreatureLevel.Level0;

	void Start () 
	{

	}

}


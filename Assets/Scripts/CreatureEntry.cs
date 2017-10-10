using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CreatureEntry : MonoBehaviour 
{
	public int id;

	public bool bHasPoison;
	public bool bHasBleed;

	public enum CreatureLevel
	{
		Level0,
		Level1,
		Level2,
		Level3,
		Level4,
	};
	public CreatureLevel creatureLevel = CreatureLevel.Level0;

	public TextMeshProUGUI description;
	public TextMeshProUGUI short_description;
	public TextMeshProUGUI attack_success_desc;
	public TextMeshProUGUI attack_fail_desc;
	public TextMeshProUGUI defend_success_desc;
	public TextMeshProUGUI defend_fail_desc;
	public TextMeshProUGUI encounter_result_good_desc;
	public TextMeshProUGUI encounter_result_bad_desc;


	void Start () 
	{

	}

}


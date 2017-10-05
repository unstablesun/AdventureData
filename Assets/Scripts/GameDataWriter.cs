using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;
using System.IO;

public class GameDataWriter : MonoBehaviour 
{
	public GameObject GridLayout;

	void Start () 
	{
		ParseData ();
	}
	
	void Update () 
	{
		
	}


	public void ParseData () 
	{
		string path = "Assets/Resources/WorldData.py";
		StreamWriter writer = new StreamWriter(path, true);

		GridLayoutGroup glg = GridLayout.GetComponentInChildren<GridLayoutGroup> ();

		Button[] glgButtons = glg.GetComponentsInChildren<Button> ();

		//int colorIndex = 0;
		int lindex = 0;
		foreach(Button bObj in glgButtons)
		{

			WorldLocation objectScript = bObj.GetComponent<WorldLocation> ();

			bool canGoNorth = objectScript.bNorth;
			bool canGoEast = objectScript.bEast;
			bool canGoWest = objectScript.bWest;
			bool canGoSouth = objectScript.bSouth;

			TextMeshProUGUI description = objectScript.description;
			TextMeshProUGUI short_description = objectScript.short_description;
			TextMeshProUGUI secrete_description = objectScript.secrete_description;

			string descrip = description.text;
			string descripShort = short_description.text;
			string descripSecrete = secrete_description.text;

			WorldLocation.EnviroHazardLevel hazardLevel = objectScript.hazardLevel;
			string hazard = hazardLevel.ToString ();

			int area = objectScript.area;

			string northString = "Blocked";
			string eastString = "Blocked";
			string westString = "Blocked";
			string southString = "Blocked";

			if (canGoNorth == true) {
				int areaNum = area - 6;
				northString = "area" + areaNum;
			}

			if (canGoEast == true) {
				int areaNum = area + 1;
				eastString = "area" + areaNum;
			}

			if (canGoWest == true) {
				int areaNum = area - 1;
				westString = "area" + areaNum;
			}

			if (canGoSouth == true) {
				int areaNum = area + 6;
				southString = "area" + areaNum;
			}


			writer.WriteLine("Location" + lindex.ToString() + " = {\'north\': \'"+northString+"\'"+
				", \'east\': \'" + eastString + "\'" +
				", \'west\': \'" + westString + "\'" +
				", \'south\': \'" + southString + "\'" +
				", \'description\': \'" + descrip + "\'" +
				", \'short_description\': \'" + descripShort + "\'" +
				", \'secrete_description\': \'" + descripSecrete + "\'" +
				", \'hazard_level\': \'" + hazard + "\'" +
				"}");



			lindex++;
		}

		//add two spaces
		writer.WriteLine(" ");
		writer.WriteLine(" ");
			

			writer.WriteLine("WorldLocations = {" +
				"\'area0\': Location0, " +
				"\'area1\': Location1, " +
				"\'area2\': Location2, " +
				"\'area3\': Location3, " +
				"\'area4\': Location4, " +
				"\'area5\': Location5, " +
				"\'area6\': Location6, " +
				"\'area7\': Location7, " +
				"\'area8\': Location8, " +
				"\'area9\': Location9, " +
				"\'area10\': Location10, " +
				"\'area11\': Location11, " +
				"\'area12\': Location12, " +
				"\'area13\': Location13, " +
				"\'area14\': Location14, " +
				"\'area15\': Location15, " +
				"\'area16\': Location16, " +
				"\'area17\': Location17, " +
				"\'area18\': Location18, " +
				"\'area19\': Location19, " +
				"\'area20\': Location20, " +
				"\'area21\': Location21, " +
				"\'area22\': Location22, " +
				"\'area23\': Location23, " +
				"\'area24\': Location24, " +
				"\'area25\': Location25, " +
				"\'area26\': Location26, " +
				"\'area27\': Location27, " +
				"\'area28\': Location28, " +
				"\'area29\': Location29, " +
				"\'area30\': Location30, " +
				"\'area31\': Location31, " +
				"\'area32\': Location32, " +
				"\'area33\': Location33, " +
				"\'area34\': Location34, " +
				"\'area35\': Location35, " +
			"}");
		

		writer.Close();

		//needed?
		//AssetDatabase.ImportAsset(path); 
		//TextAsset asset = (TextAsset)Resources.Load("WorldData.py");

	}

}

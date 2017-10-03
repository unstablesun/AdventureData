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
				"}");



			lindex++;
		}

		writer.Close();

		//needed?
		//AssetDatabase.ImportAsset(path); 
		//TextAsset asset = (TextAsset)Resources.Load("WorldData.py");

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class WriteGameData
{
	[MenuItem("Tools/Write world data file")]
	static void WriteString()
	{
		string path = "Assets/Resources/WorldData.py";

		//Write some text to the test.txt file
		StreamWriter writer = new StreamWriter(path, true);
		writer.WriteLine("Test");
		writer.Close();

		//Re-import the file to update the reference in the editor
		AssetDatabase.ImportAsset(path); 
		TextAsset asset = (TextAsset)Resources.Load("WorldData.py");

		//Print the text from the file
		//Debug.Log(asset.text);
	}

	[MenuItem("Tools/Read file")]
	static void ReadString()
	{
		string path = "Assets/Resources/WorldData.py";

		//Read the text from directly from the test.txt file
		StreamReader reader = new StreamReader(path); 
		Debug.Log(reader.ReadToEnd());
		reader.Close();
	}

}

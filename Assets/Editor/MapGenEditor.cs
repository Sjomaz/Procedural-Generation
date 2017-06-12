﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{

    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }

        if (GUILayout.Button("Randomise Seed"))
        {
            var rand = new System.Random();
            mapGen.seed = rand.Next();
            mapGen.GenerateMap();
        }
        if (GUILayout.Button ("Generate")) {
			mapGen.GenerateMap ();
		}
    }
}
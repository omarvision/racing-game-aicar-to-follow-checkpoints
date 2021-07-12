using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AIControl))]
public class AIControlEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        AIControl script = (AIControl)target;

        GUI.backgroundColor = Color.yellow;
        if (GUILayout.Button("Calc First Checkpoint") == true)
        {
            script.CalcFirstCheckpoint();
        }
    }
}
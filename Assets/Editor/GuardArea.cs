using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GuardPatrol))]
public class GuardArea : Editor {

    void OnSceneGUI() {
        GuardPatrol guardArea = (GuardPatrol) target;
        Handles.color = Color.cyan;

        Handles.DrawLine(guardArea.cornerA, new Vector3(guardArea.cornerA.x, (guardArea.cornerA.y + guardArea.cornerB.y) / 2, guardArea.cornerB.z));
        Handles.DrawLine(guardArea.cornerA, new Vector3(guardArea.cornerB.x, (guardArea.cornerB.y + guardArea.cornerA.y) / 2, guardArea.cornerA.z));

        Handles.DrawLine(guardArea.cornerB, new Vector3(guardArea.cornerA.x, (guardArea.cornerA.y + guardArea.cornerB.y) / 2, guardArea.cornerB.z));
        Handles.DrawLine(guardArea.cornerB, new Vector3(guardArea.cornerB.x, (guardArea.cornerB.y + guardArea.cornerA.y) / 2, guardArea.cornerA.z));
    }

}

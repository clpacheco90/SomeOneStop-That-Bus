//#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor( typeof(ReplaceObjectManager) )]
public class ReplaceManagerInspector : Editor {

    public override void OnInspectorGUI() {
        DrawDefaultInspector();
        EditorGUILayout.BeginHorizontal();
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Auto Aling Side-by-Side", EditorStyles.miniButton)) {
                ReplaceObjectManager r = (ReplaceObjectManager)target;
                r.Join();
                foreach (Transform c in r._childrens) {
                    c.gameObject.GetComponent<ReplaceBarrier>().Join();
                }
            }
        }
        EditorGUILayout.EndHorizontal();        
    }
}
//#endif

using UnityEditor;
using UnityEngine;

namespace Recorder
{
    [CustomEditor(typeof(TransformRecorder))]
    public class TransformsRecorderInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var script = (TransformRecorder)target;

            if (GUILayout.Button("RecordTransform"))
            {
                // Do something when the button is clicked
                script.RecordTransforms();
            }
            
            if (GUILayout.Button("LoadTransform"))
            {
                // Do something when the button is clicked
                script.LoadTransforms();
            }
        }
    }
}
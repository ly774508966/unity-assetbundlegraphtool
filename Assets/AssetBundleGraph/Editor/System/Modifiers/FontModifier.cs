using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace AssetBundleGraph.Modifiers {

	/*
	 * Code template for Font modifier.
	 * You can copy and create your CustomModifier.
	 */ 

	[Serializable] 
	[CustomModifier("Default Modifier(Font)", typeof(Font))]
	public class FontModifier : IModifier {
		
		public FontModifier () {}

		public bool IsModified (object asset) {
			//var anim = asset as Font;

			// Do your work here

			var changed = false;
			return changed; 
		}

		public void Modify (object asset) {
			//var anim = asset as Font;

			// Do your work here
		}

		public void OnInspectorGUI (Action onValueChanged) {
			GUILayout.Label("Implement your modifier for this type.");
		}

		public string Serialize() {
			return JsonUtility.ToJson(this);
		}
	}

}
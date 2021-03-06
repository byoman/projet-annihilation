using UnityEngine;
using System.Collections;
 
namespace RTS {
	/// <summary>
	/// Ressource manager est la classe qui contient toutes les constantes
	/// necessaires fonctionnement du jeu, elles peuvent ainsi etre modifies
	/// plus aisement.
	/// </summary>
	public static class RessourceManager {

		//variables camera
		public static int ScrollWidth { get { return 15; } }
		public static float ScrollSpeed { get { return 25; } }
		public static float RotateAmount { get { return 10; } }
		public static float RotateSpeed { get { return 100; } }
		public static float MinCameraHeight { get { return 10; } }
		public static float MaxCameraHeight { get { return 100; } }

		//variables selection
		private static Vector3 invalidPosition = new Vector3 (-9999, -9999, -9999);
		public static Vector3 InvalidPosition { get { return invalidPosition; } }

		//variables boite de selection
		private static GUISkin selectBoxSkin;
		public static GUISkin SelectBoxSkin { get { return selectBoxSkin; } }
		public static void StoreSelectBoxItems(GUISkin skin)
		{
			selectBoxSkin = skin;
		}
		private static Bounds invalidBounds = new Bounds(new Vector3(-9999, -9999, -9999), new Vector3(0, 0, 0));
		public static Bounds InvalidBounds { get { return invalidBounds; } } 

		//variable/methodes de creation des unites
		public static int BuildSpeed { get { return 2; } }

		//variables/methodes des world object
		private static GameObjectList gameObjectList;
		public static void SetGameObjectList(GameObjectList objectList)
		{
			gameObjectList = objectList;
		}

		public static GameObject GetBuilding(string name)
		{
			return gameObjectList.GetBuilding(name);
		}

		public static GameObject GetUnit(string name)
		{
			return gameObjectList.GetUnit (name);
		}

		public static GameObject GetWorldObject(string name)
		{
			return gameObjectList.GetWorldObject (name);
		}

		public static GameObject GetPlayerObject()
		{
			return gameObjectList.GetPlayerObject ();
		}

		public static Texture2D GetBuildImage(string name)
		{
			return gameObjectList.GetBuildImage(name);
		}



	}

}



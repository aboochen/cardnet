using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace LongBooGames
{

	public class MainSceneManager : MonoBehaviour
	{
		[SerializeField]
		Text _testText = null;

		GameNetWorkManager _GameNetWorkManagerCtrl;

		void Start ()
		{

			if (_GameNetWorkManagerCtrl == null) {
				GameObject[] gos;
				gos = GameObject.FindGameObjectsWithTag ("NetWorkManager");

				if (gos.Length > 0) {
					_GameNetWorkManagerCtrl = gos [0].gameObject.GetComponent<GameNetWorkManager> ();
				}
			}
				
			GameManager.Instance.Init ();
			GameManager.Instance.TestText = _testText;
		}
			
	}

}



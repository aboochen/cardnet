using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

using LongBooGames.Common;
using UnityEngine.UI;

namespace LongBooGames
{
	
	public class GameManager : Singleton<GameManager>
	{

		public List<Player> allPlayer = new List<Player> ();

		NetworkIdentity _NetworkIdentity;

		public Text TestText = null;

		void Start ()
		{
			if (_NetworkIdentity == null) {
				_NetworkIdentity = this.gameObject.AddComponent<NetworkIdentity> ();
				_NetworkIdentity.serverOnly = true;	
			}
		}

		void Update ()
		{
			if (TestText != null) {
				TestText.text = allPlayer.Count.ToString ();
			}
		}

		public void Init ()
		{
			Debug.Log ("Game Manager Init!!");
		}

		public void Login (Player player)
		{
			allPlayer.Add (player);
			player.RpcSetPlayer (allPlayer.Count);
		}

	}


}

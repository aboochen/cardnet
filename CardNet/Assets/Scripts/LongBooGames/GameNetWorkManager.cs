using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

using LongBooGames.Common;

namespace LongBooGames
{
	public class GameNetWorkManager : Singleton<GameNetWorkManager>
	{
		[SerializeField]
		NetworkManager _NetWorkMnager;

		NetworkIdentity _NetworkIdentity;

		public List<Player> allPlayer = new List<Player>();

		void Start () 
		{
			_NetworkIdentity = this.gameObject.AddComponent<NetworkIdentity> ();
		}

		public void Login(Player player)
		{
			allPlayer.Add(player);
			player.RpcSetPlayer(allPlayer.Count);
		}


	}
}



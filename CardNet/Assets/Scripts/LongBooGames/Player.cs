using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace LongBooGames
{

	public class Player : NetworkBehaviour
	{

		public Image ImgPlayer1;
		public Image ImgPlayer2;
		GameNetWorkManager gm;

		void Start ()
		{
			if (isServer)
			{
				gm = GameObject.Find("GM").GetComponent<GameNetWorkManager>();
				gm.Login(this);
			}
		}

		[ClientRpc]
		public void RpcSetPlayer(int id)
		{
			if (isLocalPlayer)
			{
				switch (id)
				{
				case 1:
					ImgPlayer1.gameObject.SetActive(true);
					break;
				case 2:
					ImgPlayer2.gameObject.SetActive(true);
					break;
				}
			}
		}

	}
}

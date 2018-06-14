using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace LongBooGames
{

	public class Player : NetworkBehaviour
	{

		public Image ImgPlayer1;
		public Image ImgPlayer2;
		//GameManager gm;


		NetworkIdentity _NetworkIdentity;

		void Start ()
		{
			ImgPlayer1.gameObject.SetActive (false);
			ImgPlayer2.gameObject.SetActive (false);

			if (_NetworkIdentity == null) {
				_NetworkIdentity = this.gameObject.GetComponent<NetworkIdentity> ();
			}

			if (isServer) {
				//gm = GameObject.Find("GM").GetComponent<GameManager>();
				//gm.Login(this);

				GameManager.Instance.Login (this);

				_NetworkIdentity.serverOnly = true;	
			}
		}

		[ClientRpc]
		public void RpcSetPlayer (int id)
		{
			//if (isLocalPlayer) {
				switch (id) {
				case 1:
					ImgPlayer1.gameObject.SetActive (true);
					break;
				case 2:
					ImgPlayer2.gameObject.SetActive (true);
					break;
				}
			//}
		}


	}
}

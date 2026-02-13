using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Trail.API;
using UnityEngine;

namespace Trail.Account
{
	public class AccountManager : MonoBehaviour
	{
		private void Awake()
		{
			mAccount = null;
		}

		public async UniTask<APIResult> Login(CancellationToken iCancellationToken = default)
		{
			var aAPI = new API.Account.Login();

			return new APIResult(aAPI);
		}

		//Properties
		private Account mAccount;
	}
}
using TMPro;
using UnityEngine;
using UnityEngine.UI;



namespace Trail.UI
{
	public class View_Login : MonoBehaviour
	{
		private void Awake()
		{
			mButtonLogin.onClick.AddListener(OnButtonPress_Login);
		}
		private void OnButtonPress_Login()
		{
			bool   aIsAccountValid  = CheckIsInputValid(mInputField_Account.text);
			bool   aIsPasswordValid = CheckIsInputValid(mInputField_Password.text);
			string aInvalidMessage  = "";
			aInvalidMessage += aIsAccountValid  ? "" : $"Login, Input text invalid [Account filed]: {mInputField_Account.text}";
			aInvalidMessage += aInvalidMessage != "" && !aIsPasswordValid ? "\n" : "";
			aInvalidMessage += aIsPasswordValid ? "" : $"Login, Input text invalid [Password filed]: {mInputField_Password.text}";
			if (aIsAccountValid && aIsPasswordValid)
			{
				Debug.Log($"Login, Account: {mInputField_Account.text}, Password: {mInputField_Password.text}");
			}
			else
			{
				Debug.LogWarning(aInvalidMessage);
			}
		}
		private bool CheckIsInputValid(string iInputText)
		{
			if (iInputText == "")
			{
				return false;
			}
			//TODO: check other invalid format
			return true;
		}

		//Properties
		public TMP_InputField mInputField_Account;
		public TMP_InputField mInputField_Password;
		public Button         mButtonLogin;
	}
}
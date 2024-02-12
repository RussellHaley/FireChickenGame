using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{

	public void GoToScene(string scene)
	{
		SceneManager.LoadScene(scene);
	}


	public void Quit_OnClick()
	{
		Debug.Log("End Application");
		Application.Quit();
	}
	
}

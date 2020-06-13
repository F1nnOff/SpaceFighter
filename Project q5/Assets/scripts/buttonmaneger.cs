using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonmaneger : MonoBehaviour {

	public void NewGamebtn(string newgamelevel)
    {
        SceneManager.LoadScene(newgamelevel);
    }
    public void ExitGameBtn()
    {
        Application.Quit();
    }
}

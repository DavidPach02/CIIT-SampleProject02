using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadScreen : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        LoadLevel(levelName, LoadSceneMode.Single);
    }

    public void LoadLevelAdditive(string levelName)
    {
        LoadLevel(levelName, LoadSceneMode.Additive);
    }

    public void LoadLevel(string levelName, LoadSceneMode loadSceneMode)
    {
        if (levelName == string.Empty)
        {
            Debug.LogError("No level name provided!");
        }

        Debug.Log(levelName + " loaded");

        SceneManager.LoadScene(levelName, loadSceneMode);
    }


    public void LoadLevelAsync(string levelName)
    {
        TestSaveSystem.Instance.loadLevel = true;
        Debug.Log(TestSaveSystem.Instance.loadLevel);
        StartCoroutine(AsyncLoad(levelName));
    }

    IEnumerator AsyncLoad(string levelName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(levelName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}

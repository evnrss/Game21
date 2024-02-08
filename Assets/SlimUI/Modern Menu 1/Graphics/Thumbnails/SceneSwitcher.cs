using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneSwitcher : MonoBehaviour
{
    public SceneAsset sceneToLoad;

    public void SwitchScene()
    {
        if (sceneToLoad == null)
        {
            Debug.LogError("Scene not set in the inspector.");
            return;
        }

        string sceneName = sceneToLoad.name;
        SceneManager.LoadScene(sceneName);
    }
}
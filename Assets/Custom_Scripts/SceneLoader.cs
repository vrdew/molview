using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    /// Request that the MRTK SceneSystem load a scene of a given name.
    public void LoadScene(string sceneName) => CoreServices.SceneSystem.LoadContent(sceneName, LoadSceneMode.Single);
    public void UnLoadScene(string sceneName) => CoreServices.SceneSystem.UnloadContent(sceneName);
}
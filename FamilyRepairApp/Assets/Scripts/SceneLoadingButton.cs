using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingButton : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoadWhenClicked = "ENTER SCENE NAME HERE!";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoadWhenClicked);
    }
}
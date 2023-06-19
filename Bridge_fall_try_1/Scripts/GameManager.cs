using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completelevelUi;
    public GameObject RetrylevelUi;
    //public GameObject exitUi;
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    int i = 0;

    void Start()
    {
        scenePaths = new string [6] {"Level1" ,"Level2" ,"Level3", "Level4", "Level5", "Level6"};
    }

    public void EndGame()
    {
        Invoke("call_Finish_Ui_Screen", 6.0f);
    }

    public void RetryScreen()
    {
        RetrylevelUi.SetActive(true);
    }
    public void NextGame()
    {
        NextLevel();
    }

    public void RestartGame()
    {
        RestartLevel();
    }

    void call_Finish_Ui_Screen()
    {
        completelevelUi.SetActive(true);
    }

    void NextLevel()
    {
        if (SceneManager.GetSceneByBuildIndex(0) == SceneManager.GetActiveScene())
        {
            i = 1;
        }

        if (SceneManager.GetSceneByBuildIndex(1) == SceneManager.GetActiveScene() )
        {
            i = 2;
        }

        if (SceneManager.GetSceneByBuildIndex(2) == SceneManager.GetActiveScene())
        {
            i = 3;
        }

        if (SceneManager.GetSceneByBuildIndex(3) == SceneManager.GetActiveScene())
        {
            i = 4;
        }

        if (SceneManager.GetSceneByBuildIndex(4) == SceneManager.GetActiveScene())
        {
            i = 5;
        }

        //if (SceneManager.GetSceneByBuildIndex(5) == SceneManager.GetActiveScene())
        //{
        //    exitUi.SetActive(true);
        //}



        print("entered game manager");
        print(scenePaths[i]);
        SceneManager.LoadScene(scenePaths[i], LoadSceneMode.Single);
    }

    void RestartLevel()
    {
        print("Restarted level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

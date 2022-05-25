
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
   public void GetNextState()
    {
        int CurrentSceneIndex;
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex + 1);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
      public  void GetFirstState()
    {   
        SceneManager.LoadScene(0);

    }
    
}


using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Playerinfo;
    public float SceneLoaderDelay = 1f;
    private void Update()
    {
        if((Playerinfo.position.x<-50)||(Playerinfo.position.x > 50))
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        FindObjectOfType<SceneLoader>().GetNextState();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        GameOver();
    }
}

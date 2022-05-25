using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    void Update()
    {  ScoreText.text=player.position.z.ToString("0");
        
    }
}

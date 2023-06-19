using UnityEngine;
using TMPro;
public class NextLevelScript : MonoBehaviour
{
    public GameManager NextLevel;

    public void ButtonPress()
    {
        NextLevel.NextGame();
    }
 
}

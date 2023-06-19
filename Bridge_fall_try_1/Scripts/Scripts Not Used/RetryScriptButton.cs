using UnityEngine;
using TMPro;
public class RetryScriptButton : MonoBehaviour
{
    public GameManager RetryLevel;

    public void ButtonPress()
    {
        print("Button pressed");
        RetryLevel.RestartGame();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public void ClicBotonRetry()
    {
        SceneManager.LoadScene(0);
    }
}

using UnityEngine.SceneManagement;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    bool gameHasEndend  = false;
    public float restartDelay = 1f;
    public void music()
    {
        Debug.Log("Music Maestro");
    }
   public void EndGame()
    {
        if (gameHasEndend == false)
        {
            gameHasEndend = true;
            Debug.Log("game over pleb");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

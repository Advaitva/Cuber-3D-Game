using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool gamehasEnded = false;
    public float delay = 1f;


    void Restart()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public GameObject completeLevelUI;
    public void levelEnded()
    {
        completeLevelUI.SetActive(true);
    }
   public void EndGame()
    {
        
        if(gamehasEnded==false)
        {
            gamehasEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", delay);
            
            //    Restart();
        }
    }

}

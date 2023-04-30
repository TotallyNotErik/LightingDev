using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
   public void StartGame()
   {
      if (SceneManager.GetActiveScene().buildIndex == 1)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
      else if (SceneManager.GetActiveScene().buildIndex == 0)
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}

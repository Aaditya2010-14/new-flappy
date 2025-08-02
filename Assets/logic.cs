using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class logic : MonoBehaviour
{

    public int playerscore = 0;
    public UIDocument uiDocument;
    public Label scoretext;
    public GameObject gameOverScreen;
    
    public void Score()
    {
        playerscore = playerscore + 1;
        scoretext.text = playerscore.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    
}


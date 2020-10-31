using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public GameObject endScrn;
    bool isEnded = false;

    public void GameEnded(){
        if(isEnded == false){
            isEnded = true;
            endScrn.gameObject.SetActive(true);
            Debug.Log("Game Over");
            Invoke("Restart", 3f);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public GameObject endScrn;
    public Text textEnd;
    public Text textScore;
    bool isEnded = false;

    public void GameEnded(int condition){
        switch(condition)
        {
            case 1:
                textEnd.text = "You WIN!!";
                break;
            default:
                textEnd.text = "Game Over";
                break;
        }
        if(isEnded == false){
            isEnded = true;
            textScore.text = "X" + ScoreManager.score.ToString();
            endScrn.gameObject.SetActive(true);
        }
    }
}


using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    public Coincollect MyCoinCollect;
    public Text ScoreText;
    public int ScoreNum;

   
    void Update()
    {
        ScoreNum = MyCoinCollect.score;
        ScoreText.text = ScoreNum + " Coins";
    }
}

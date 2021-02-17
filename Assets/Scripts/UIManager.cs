using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Image player1, player2, player1Hand, player2Hand;
    public Sprite muk, jji, ppa, fmuk, fjji;
    public void Display(GameManager.Result result)
    {
        if (result == GameManager.Result.Draw)
        {
            if (GameManager.turn.HasValue)
            {
                if (GameManager.turn.Value)
                {
                    player1.color = Color.yellow;
                    player2.color = Color.white;
                }
                else
                {
                    player1.color = Color.white;
                    player2.color = Color.yellow;
                }
            }
            else
            {
                player1.color = player2.color = Color.white;
            }
        }
        else
        {
            switch(result)
            {
                case GameManager.Result.Win:
                    player1.color = Color.green;
                    player2.color = Color.red;
                    break;
                case GameManager.Result.Lose:
                    player1.color = Color.red;
                    player2.color = Color.green;
                    break;
                default:
                    player1.color = player2.color = Color.white;
                    break;
            }
        }
        switch (GameManager.player1.outHand)
        {
            case Player.OutHand.Rock:
                if(Fword() < 0.000625)
                {
                    player1Hand.sprite = fmuk;
                }
                else
                {
                    player1Hand.sprite = muk;
                }
                break;
            case Player.OutHand.Scissors:
                if (Fword() < 0.000625)
                {
                    player1Hand.sprite = fjji;
                }
                else
                {
                    player1Hand.sprite = jji;
                }
                break;
            case Player.OutHand.Paper:
                player1Hand.sprite = ppa;
                break;
        }
        switch (GameManager.player2.outHand)
        {
            case Player.OutHand.Rock:
                if (Fword() < 0.000625)
                {
                    player2Hand.sprite = fmuk;
                }
                else
                {
                    player2Hand.sprite = muk;
                }
                break;
            case Player.OutHand.Scissors:
                if (Fword() < 0.000625)
                {
                    player2Hand.sprite = fjji;
                }
                else
                {
                    player2Hand.sprite = jji;
                }
                break;
            case Player.OutHand.Paper:
                player2Hand.sprite = ppa;
                break;
        }
    }
    public float Fword()
    {
        float f = Random.Range(0, 1f);
        return f;
    }
}

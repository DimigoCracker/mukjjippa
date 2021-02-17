using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager: MonoBehaviour
{
    public enum Result
    {
        Draw,
        Win,
        Lose
    }
    public UIManager uiManager;
    public static Player player1 = new Player(), player2 = new Player();
    public static bool? turn = null;
    private Result RockScissorsPaper()
    {
        player2.outHand = (Player.OutHand)Random.Range(0, 3);
        if (player1.outHand == player2.outHand)
            return Result.Draw;
        else if (player1.outHand == Player.OutHand.Rock)
        {
            if (player2.outHand == Player.OutHand.Scissors)
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
        }
        else if (player1.outHand == Player.OutHand.Scissors)
        {
            if (player2.outHand == Player.OutHand.Paper)
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
        }
        else
        {
            if (player2.outHand == Player.OutHand.Rock)
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
        }
    }

    private Result MukJjiPpa()
    {
        if (turn.HasValue)
        {
            switch (RockScissorsPaper())
            {
                case Result.Draw:
                    return turn.Value ? Result.Win : Result.Lose;
                case Result.Win:
                    if (!turn.Value)
                        turn = true;
                    return Result.Draw;
                case Result.Lose:
                    if (turn.Value)
                        turn = false;
                    return Result.Draw;
            }
            return Result.Draw;
        }
        else
        {
            switch (RockScissorsPaper())
            {
                case Result.Draw:
                    break;
                case Result.Win:
                    turn = true;
                    break;
                case Result.Lose:
                    turn = false;
                    break;
            }
            return Result.Draw;
        }
    }

    public void OnClick(int type)
    {
        player1.outHand = (Player.OutHand)type;
        Result r = MukJjiPpa();
        if(r != Result.Draw)
        {
            turn = null;
        }
        uiManager.Display(r);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(0);
        }
    }
}

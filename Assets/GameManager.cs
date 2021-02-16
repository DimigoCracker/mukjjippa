using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Result
{
    Draw,
    Win,
    Lose
}
public enum OutHand //가위바위보 열거체
{
    Rock,
    Scissors,
    Paper
}

public class GameManager:MonoBehaviour
{
    List<Player> players;
    public Result RockSciserPaper(Player player, Player other)
    {
        if (player.SelectedOutHand == other.SelectedOutHand)
            return Result.Draw;
        else if (player.SelectedOutHand == OutHand.Scissors)
        {
            if (other.SelectedOutHand == OutHand.Paper)
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
        }
        else if (player.SelectedOutHand == OutHand.Rock)
        {
            if (other.SelectedOutHand == OutHand.Scissors)
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
            if (other.SelectedOutHand == OutHand.Rock)
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }
        }
    }

    public Result MukJjiPpa(Player attackPlayer, Player defancePlayer)
    {
        if (RockSciserPaper(attackPlayer, defancePlayer) == Result.Draw)
            return Result.Win;
        else if (RockSciserPaper(attackPlayer, defancePlayer) == Result.Win)
        {
            return Result.Draw;
        }
        else
        {
            attackPlayer.ChangeAttackRight(false);
            defancePlayer.ChangeAttackRight(true);
            return Result.Draw;
        }
    }
}

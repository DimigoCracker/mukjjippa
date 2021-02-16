using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool attackRight;    //공격권
    private OutHand outHand;
    public OutHand SelectedOutHand
    {
        get { return outHand; }
    }

    public void ChangeAttackRight(bool attackRight)
    {
        this.attackRight = attackRight;
    }

    public void SelectOutHand(OutHand outHand)
    {
        this.outHand = outHand;
    }
}

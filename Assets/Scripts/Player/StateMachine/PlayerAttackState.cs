using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttackState : PlayerBaseState
{
    private bool alreadyAppliedForce;
    private bool alreadyAppliedDealing;

    public PlayerAttackState(PlayerStateMachine playerStateMachine) : base(playerStateMachine)
    {
    }

    public override void Enter()
    {
        //stateMachine.MovementSpeedModifier = 0;
        //base.Enter();

        //StartAnimation(stateMachine.Player.AnimationData.AttackParameterHash);

        stateMachine.MovementSpeedModifier = 0;
        base.Enter();
        StartAnimation(stateMachine.Player.AnimationData.AttackParameterHash);
        StartAnimation(stateMachine.Player.AnimationData.BaseAttackParameterHash);

        alreadyAppliedForce = false;
        alreadyAppliedDealing = false;

        stateMachine.MovementSpeedModifier = 0;
    }

    public override void Exit()
    {
        base.Exit();

        //StopAnimation(stateMachine.Player.AnimationData.AttackParameterHash);
        StopAnimation(stateMachine.Player.AnimationData.AttackParameterHash);
        StopAnimation(stateMachine.Player.AnimationData.BaseAttackParameterHash);
    }

    public override void Update()
    {
        base.Update();

        //ForceMove();

        //float normalizedTime = GetNormalizedTime(stateMachine.Player.Animator, "Attack");
        //if (normalizedTime < 1f)
        //{
        //    if (normalizedTime >= stateMachine.Player.Data.AttakData.AttackInfoDatas[0].ForceTransitionTime)
        //        TryApplyForce();

        //    if (!alreadyAppliedDealing && normalizedTime >= stateMachine.Player.Data.AttakData.AttackInfoDatas[stateMachine.Player.AnimationData.AttackParameterHash].ComboTransitionTime)
        //    {
        //        stateMachine.Player.Weapon.SetAttack(stateMachine.Player.Data.AttakData.AttackInfoDatas[stateMachine.Player.AnimationData.AttackParameterHash].Damage, stateMachine.Player.Data.AttakData.AttackInfoDatas[stateMachine.Player.AnimationData.AttackParameterHash].Force);
        //        stateMachine.Player.Weapon.gameObject.SetActive(true);
        //        alreadyAppliedDealing = true;
        //    }

        //    if (alreadyAppliedDealing && normalizedTime >= stateMachine.Player.Data.AttakData.AttackInfoDatas[stateMachine.Player.AnimationData.AttackParameterHash].ComboTransitionTime)
        //    {
        //        stateMachine.Player.Weapon.gameObject.SetActive(false);
        //    }
        //}
        if(Input.GetMouseButton(0))
        {
            Debug.Log("АјАн");
            stateMachine.Player.Weapon.SetAttack(stateMachine.Player.Data.AttakData.AttackInfoDatas[0].Damage, stateMachine.Player.Data.AttakData.AttackInfoDatas[0].Force);
            stateMachine.Player.Weapon.gameObject.SetActive(true);
        }
        else
        {
            stateMachine.Player.Weapon.gameObject.SetActive(false);
        }

    }

    private void TryApplyForce()
    {
        if (alreadyAppliedForce) return;
        alreadyAppliedForce = true;

        stateMachine.Player.ForceReceiver.Reset();

        stateMachine.Player.ForceReceiver.AddForce(stateMachine.Player.transform.forward * stateMachine.Player.Data.AttakData.AttackInfoDatas[0].Force);

    }
}
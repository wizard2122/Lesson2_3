using UnityEngine;

public abstract class AirborneState : MovementState
{
    private float _baseGravity;

    public AirborneState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _baseGravity = character.Config.AirborneStateConfig.BaseGravity;

    public override void Enter()
    {
        base.Enter();

        View.StartAirborne();
    }

    public override void Exit()
    {
        base.Exit();

        View.StopAirborne();
    }

    public override void Update()
    {
        base.Update();

        Data.YVelocity -= GetFravityMultiplier() * Time.deltaTime;
    }

    protected virtual float GetFravityMultiplier() => _baseGravity;
}

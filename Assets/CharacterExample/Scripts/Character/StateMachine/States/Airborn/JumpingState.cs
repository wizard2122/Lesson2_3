public class JumpingState : AirborneState
{
    private readonly JumpingStateConfig _config;

    public JumpingState(IStateSwitcher stateSwitcher, StateMachineData data, Character character) : base(stateSwitcher, data, character)
        => _config = character.Config.AirborneStateConfig.JumpingStateConfig;

    public override void Enter()
    {
        base.Enter();

        View.StartJumping();

        Data.Speed = _config.Speed;
        Data.YVelocity = _config.StartYVelocity;

    }

    public override void Exit()
    {
        base.Exit();

        View.StopJumping();
    }

    public override void Update()
    {
        base.Update();

        if (Data.YVelocity < 0)
            StateSwitcher.SwitchState<FallingState>();
    }
}

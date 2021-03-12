public struct WalkSetting
{
    public float Speed;


    public static WalkSetting Default()
    {
        WalkSetting walkSetting;

        walkSetting.Speed = 1.5f;

        return walkSetting;
    }
}

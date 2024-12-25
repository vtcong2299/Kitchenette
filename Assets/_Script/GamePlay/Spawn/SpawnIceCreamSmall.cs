
public class SpawnIceCreamSmall : SpawnObj
{
    public static SpawnIceCreamSmall instance;
    private void OnEnable()
    {
        instance = this;
    }
    private void OnDisable()
    {
        instance = null;
    }
}

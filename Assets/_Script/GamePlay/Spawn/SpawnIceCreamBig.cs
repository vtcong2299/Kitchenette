
public class SpawnIceCreamBig : SpawnObj
{
    public static SpawnIceCreamBig instance;
    private void OnEnable()
    {
        instance = this;
    }
    private void OnDisable()
    {
        instance = null;
    }
}


public class SpawnCoca : SpawnObj
{
    public static SpawnCoca instance;
    private void OnEnable()
    {
        instance = this;
    }
    private void OnDisable()
    {
        instance = null;
    }
}   


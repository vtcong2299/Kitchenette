
public class Cooking : ButtonInventory
{
    public override void ClickButton()
    {
        UIManager.instance.OnClickIngredientCookButton(item);
        Destroy(gameObject);
    }
}

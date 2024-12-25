
public class IngredientBase : ButtonInventory
{
    public override void ClickButton()
    {
        UIManager.instance.AddToItemList(item);
    }
}

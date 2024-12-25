public class IngredientInBag : ButtonInventory
{
    public override void ClickButton()
    {
        UIManager.instance.RemoveItemList(item);
        UIManager.instance.AddToCookList(item);
        Destroy(gameObject);
    }
}

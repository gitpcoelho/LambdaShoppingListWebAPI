using LambdaShoppingListWebAPI.Models;
using System.Collections.Generic;

namespace LambdaShoppingListWebAPI.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemToShoppingList(ShoppingListModel shoppingList);
        void DeleteItemFromShoppingList(string shoppingListName);
    }
}
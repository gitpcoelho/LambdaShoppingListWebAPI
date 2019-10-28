using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaShoppingListWebAPI.Models;

namespace LambdaShoppingListWebAPI.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();

        public void AddItemToShoppingList(ShoppingListModel shoppingList)
        {
            _shoppingListStorage.Add(shoppingList.Name, shoppingList.Quantity);
        }

        public void DeleteItemFromShoppingList(string shoppingListName)
        {
            _shoppingListStorage.Remove(shoppingListName);
        }

        public Dictionary<string, int> GetItemsFromShoppingList()
        {
            return _shoppingListStorage;
        }
    }
}

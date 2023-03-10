namespace SolanaUE5.SDK.Database
{
    public class GameAccount
    {
        public string AccID { get; set; }
        public string Username { get; set; }
        public string? Password { get; set; }
        public string Gamertag { get; set; }
        public string Email { get; set; }
        public string SolAddress { get; set; }
        public int Account_level { get; set; }
        public int Season_level { get; set; }
        public int Experience { get; set; }
        public int Season_exp { get; set; }
        public int Gold { get; set; }
        public int Solarite { get; set; }

        public GameAccount(string _AccID, string _username, string _gamertag, string _email, string _soladdy, int accLVL, int sLVL, int exp, int sEXP, int gold, int solarite)
        {
            AccID = _AccID;
            Username = _username;
            Gamertag = _gamertag;
            Email = _email;
            SolAddress = _soladdy;
            Account_level = accLVL;
            Season_level = sLVL;
            Experience = exp;
            Season_exp = sEXP;
            Gold = gold;
            Solarite = solarite;
        }
    }
    public class StoreItem
    {
        public string StoreItemID { get; set; }

        public string GameItemID { get; set; }

        public string CollectibleID { get; set; }

        public string ItemName { get; set; }
        public string? ClassName { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public StoreItem(string storeItemID, string gameItemID, string itemName, string? className, string image, decimal price)
        {
            StoreItemID = storeItemID;
            GameItemID = gameItemID;
            ItemName = itemName;
            ClassName = className;
            Image = image;
            Price = price;
        }
    }
    public class Inventory : Dictionary<int, InventoryItem>
    {
        public Inventory(Dictionary<int, InventoryItem> InventoryItems) 
        {
            foreach(var item in InventoryItems)
            {
                Add(item.Key, item.Value);
            }
        }
    }

    public class InventoryItem 
    {
        public string? InventoryItemID { get; set; }
        public string? WorldItemID { get; set; }
        public string? GameItemID { get; set; }
        public int SlotNumber { get; set; }
        public InventoryItem(string? inventoryItemID, string? worldItemID, string? gameItemID, int slotNumber)
        {
            InventoryItemID = inventoryItemID;
            WorldItemID = worldItemID;
            GameItemID = gameItemID;
            SlotNumber = slotNumber;
        }
    }
    public class GameItem
    {
        public string? GameItemID { get; set; }
        public string? CollectibleID { get; set; }

        public string? Name { get; set; }
        public string? MeshClassName { get; set; }
        public string? ObjectMaterials { get; set; }

        public GameItem(string? gameItemID, string? collectibleID, string? name, string? meshClassName, string? objectMaterials)
        {
            GameItemID = gameItemID;
            CollectibleID = collectibleID;
            Name = name;
            MeshClassName = meshClassName;
            ObjectMaterials = objectMaterials;
        }
    }

    public class LoginRequest
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
    public class RequestStorePurchase
    {
        public string? UserToken { get; set; }
        public string? StoreItemID { get; set; }
    }

    public class RequestRecycler
    {
        public string? UserToken { get; set; }
        public string? InventoryItemID { get; set; }
    }
    public class JWTtoken
    {
        public string? Token { get; set; }
    }

}

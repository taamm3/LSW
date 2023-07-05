## Game Description:
The 2D Unity game is a simple shopping experience where the player can move around, enter a shop, purchase outfits using in-game coins, and view their inventory.

## Game Controls:
* Movement: The player can use either the WASD keys or arrow keys to move around the game world.
* Interaction: When the player approaches the shop, an instruction appears on the screen prompting them to press the "E" key to enter the shop.
* Shop Exit: Inside the shop, there is a back button that allows the player to exit the shop and return to the game world.
* Inventory: The player can open and close their inventory by pressing the "I" key.
* Outfit change: The player can change their outfit by clicking on any of the inventory items.
## Camera:
The game utilizes a virtual camera that follows the player as they move around the game world, providing a smooth and dynamic perspective.

## Shop:
* Interaction Prompt: When the player gets close to the shop, an instruction appears on the screen, indicating that they can press the "E" key to enter the shop.
* Coin Display: Upon entering the shop, the player's coin amount is displayed in the right corner of the screen.
* Outfit Purchases: The shop offers various outfits that the player can purchase using their in-game coins, provided they have enough funds.
* Outfit Persistence: When the player exits the shop, they keep on the last outfit they purchased, and it appears on their character in the game world.
* Default Outfit: There is a default outfit that is initially equipped by the player. This outfit always appears in the inventory alongside the purchased outfits.
## Scriptable Objects:
Each outfit in the game has a corresponding scriptable object that contains the following information:

* Index: An identifier for the outfit.
* Prefab: The visual representation of the outfit.
* Icon: The visual representation of the outfit in the inventory.
* Price: The cost of the outfit in in-game coins.
* Instance: An instance of the outfit prefab.
* Count: The number of instances of the outfit owned by the player.
* Inventory item: The instance of the item to be shown in the inventory. 
## Development Details:
* Unity Version: The game was developed using Unity version 2021.3.16f1.
* Development Time: The entire game was developed in a span of 48 hours.
* Scope Limitations: Due to time constraints, some additional features and some ideas I had, such as a character to try on clothes and a confirmation button for purchases, collecting coins etc were not implemented.
Please note that this documentation provides a high-level overview of the game's functionality and development details. For a more comprehensive understanding of the game's implementation, please refer to the source code and associated assets.

using UnityEngine;
using System.Collections;

public class G : MonoBehaviour {

	public const string HOUSE_SCENE = "House";
	public const string STREET_SCENE = "Street";
	public const string PHARMACY_SCENE = "Pharmacy";
	public const string GUNSHOP_SCENE = "GunShop";
	public const string MENU_SCENE = "Menu";
	public const string THEEND_SCENE = "TheEnd";

	public const int NO_ITEM = 0;
	public const int MEDICINE_ITEM = 1;
	public const int GUN_ITEM = 2;

	public static int item = NO_ITEM;

	public static int coins = 10;

	public static string prevScene;
}

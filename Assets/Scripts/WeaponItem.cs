using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "New Weapon", menuName = "WeaponItem")]
public class  WeaponItem: ScriptableObject
{
	public string WeapomName;
	public int BulletNumber;
	public int StartBullet;
	public int maxBullet;

	public float Damage;
	public float FireRate;
	public int FlyTime;

	public int BulletSpeed;
	public int BulletType;
	public int DamageType;

	public GameObject bullet;
	public GameObject Body;
}

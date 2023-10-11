using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text HP;
    public TMP_Text Score;
    public TMP_Text total;

    public Player Player;
     
    public GameObject Enemy;

    private List<GameObject> Enemys;
    private GameObject[] nums;
    private int Score_Value;

    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;
    public Transform SpawnPoint4;
    public Transform SpawnPoint5;
    public Transform SpawnPoint6;
    public Transform SpawnPoint7;
    public Transform SpawnPoint8;
    private int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        Enemys = new List<GameObject>();
        nums = new GameObject[20];
        Score_Value = 0;
        Score.text = Score_Value.ToString();
        HP.text = Player.CharacterHealth.returnHP().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = Player.CharacterHealth.returnHP().ToString();
        
        if(num<10)
        {
            if(Enemy!= null) { Spawn_2(); }
        }

    }

    void Spawn()
    {

    }

    void Spawn_1()
    {
        if (num < 10)
        {
            int random = Random.Range(1, 9);
            GameObject obj;
            switch (random)
            {
                case 1:
                    nums[num] = Instantiate(Enemy, SpawnPoint1.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    num++;
                    break;
                case 2:
                    nums[num] = Instantiate(Enemy, SpawnPoint2.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    break;
                case 3:
                    nums[num] = Instantiate(Enemy, SpawnPoint3.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    num++;
                    break;
                case 4:
                    nums[num] = Instantiate(Enemy, SpawnPoint4.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    num++;
                    break;
                case 5:
                    nums[num] = Instantiate(Enemy, SpawnPoint5.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    num++;
                    break;
                case 6:
                    nums[num] = Instantiate(Enemy, SpawnPoint6.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    num++;
                    break;
                case 7:
                    obj = Instantiate(Enemy, SpawnPoint7.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    num++;
                    break;
                case 8:
                    nums[num] = Instantiate(Enemy, SpawnPoint8.position, Quaternion.identity);
                    Enemys.Add(nums[num]);
                    num++;
                    break;
            }

        }
    }

    void Spawn_2()
    {
        if (num < 10)
        {
            int random = Random.Range(1, 9);
            GameObject obj;
            switch (random)
            {
                case 1:
                    Instantiate(Enemy, SpawnPoint1.position, Quaternion.identity);
                    num ++;
                    total.text = num.ToString();
                    break;
                case 2:
                    Instantiate(Enemy, SpawnPoint2.position, Quaternion.identity);
                    num++;
                    total.text = num.ToString();
                    break;
                case 3:
                    Instantiate(Enemy, SpawnPoint3.position, Quaternion.identity);
                    num++;
                    total.text = num.ToString();
                    break;
                case 4:
                    Instantiate(Enemy, SpawnPoint4.position, Quaternion.identity);
                    num++;
                    total.text = num.ToString();
                    break;
                case 5:
                    Instantiate(Enemy, SpawnPoint5.position, Quaternion.identity);
                    num++;
                    total.text = num.ToString();
                    break;
                case 6:
                    Instantiate(Enemy, SpawnPoint6.position, Quaternion.identity);
                    num++;
                    total.text = num.ToString();
                    break;
                case 7:
                    Instantiate(Enemy, SpawnPoint7.position, Quaternion.identity);
                    num++;
                    total.text = num.ToString();
                    break;
                case 8:
                    Instantiate(Enemy, SpawnPoint8.position, Quaternion.identity);
                    num++;
                    total.text = num.ToString();
                    break;
            }

        }
    }

    public void Enemydie()
    {
        Score_Value += 50 ;
        Score.text = Score_Value.ToString();
        num--;
        total.text = num.ToString();
    }

    public void Died()
    {
        for(int i = 0; i<nums.Length; i++) 
        {
            if (nums[i].activeSelf == false)
            {
                Destroy(nums[i]);
            }
        }
    }
}

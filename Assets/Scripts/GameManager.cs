using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManeger : MonoBehaviour
{
    public TMP_Text HP;
    public TMP_Text Score;
    public TMP_Text total;

    public Player Player;
     
    public GameObject Enemy;

    private List<GameObject> Enemys;
    private int Score_Value;

    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;
    public GameObject SpawnPoint4;
    public GameObject SpawnPoint5;
    public GameObject SpawnPoint6;
    public GameObject SpawnPoint7;
    public GameObject SpawnPoint8;

    private int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        Score_Value = 0;
        HP.text = Player.CharacterHealth.returnHP().ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = Player.CharacterHealth.returnHP().ToString();
        if(Player.enabled)
        {
            //Spawn();
        }
        EnemyDie();
        Score.text = Score_Value.ToString();
    }

    void Spawn()
    {
        if(Enemys.Count<20)
        {
            int random = Random.Range(1, 9);
            GameObject obj;
            switch(random) 
            {
                case 1:
                    obj = Instantiate(Enemy, SpawnPoint1.transform.position,Quaternion.identity );
                    Enemys.Add(obj);
                    break;
                case 2:
                    obj = Instantiate(Enemy, SpawnPoint2.transform.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 3:
                    obj = Instantiate(Enemy, SpawnPoint3.transform.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 4:
                    obj = Instantiate(Enemy, SpawnPoint4.transform.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 5:
                    obj = Instantiate(Enemy, SpawnPoint5.transform.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 6:
                    obj = Instantiate(Enemy, SpawnPoint6.transform.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 7:
                    obj = Instantiate(Enemy, SpawnPoint7.transform.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 8:
                    obj = Instantiate(Enemy, SpawnPoint8.transform.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
            }
            num++;
        }
    }

    void EnemyDie()
    {
        for(int i = Enemys.Count-1; i>=0; i--)
        {
            if (!Enemys[i].active)
            {
                Enemys.Remove(Enemys[i]);
                num--;
            }
        }
    }
}

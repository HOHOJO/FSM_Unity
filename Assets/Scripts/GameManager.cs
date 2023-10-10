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
        Score_Value = 0;
        HP.text = Player.CharacterHealth.returnHP().ToString();
        GameObject Ob = Instantiate(Enemy, SpawnPoint1.position, Quaternion.identity);
        Enemys.Add(Ob);
        num++;
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = Player.CharacterHealth.returnHP().ToString();
        if(Player.enabled)
        {
            if (Enemys != null) Invoke("Spawn",20f);
        }
        EnemyDie();
        Score.text = Score_Value.ToString();
    }

    void Spawn()
    {
        if (Enemys.Count < 8)
        {
            int random = Random.Range(1, 9);
            GameObject obj;
            switch (random)
            {
                case 1:
                    obj = Instantiate(Enemy, SpawnPoint1.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 2:
                    obj = Instantiate(Enemy, SpawnPoint2.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 3:
                    obj = Instantiate(Enemy, SpawnPoint3.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 4:
                    obj = Instantiate(Enemy, SpawnPoint4.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 5:
                    obj = Instantiate(Enemy, SpawnPoint5.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 6:
                    obj = Instantiate(Enemy, SpawnPoint6.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 7:
                    obj = Instantiate(Enemy, SpawnPoint7.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
                case 8:
                    obj = Instantiate(Enemy, SpawnPoint8.position, Quaternion.identity);
                    Enemys.Add(obj);
                    break;
            }
            num++;
        }
    }

    void EnemyDie()
    {
        if(Enemys!=null)
        {
            for (int i = Enemys.Count - 1; i >= 0; i--)
            {
                if (!Enemys[i].activeSelf)
                {
                    Enemys.Remove(Enemys[i]);
                    num--;
                }
            }
        }

    }
}

using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class OxygenManager : MonoBehaviour
{
    public static bool isDead;
    public Image oxygenBar;
    public float drowningSpeed;
    float fillValue;
    Player player;
    public static OxygenManager inst;
    private void Awake()
    {
        inst = this;
    }
    private void Start()
    {
        isDead = false;
        player = Player.inst;
        fillValue = player.oxygen / 100f;
    }
    public void Drowning()
    {
        if (!isDead)
        {
            if (player.oxygen <= 0&&!Player.fin)
            {
                Debug.Log("Dead");
                isDead = true;

                Dead();
            }
        }
        if (Player.fin==false)
        {
            player.oxygen -= drowningSpeed * Time.deltaTime; ;
            fillValue = player.oxygen / 100f;
            oxygenBar.fillAmount = Mathf.Lerp(oxygenBar.fillAmount, fillValue, 0.05f);
        }
       

    }

    public void DamagedByObs()
    {
        Debug.Log("Damaged by obs");
        player.oxygen -= 10;
    }

    public void OxygenTaken(float oxygen)
    {
        player.oxygen += oxygen;
        player.oxygen = Mathf.Clamp(player.oxygen, 0, 100);
    }

    private void Update()
    {
        Drowning();
    }

    void Dead()
    {
        player.Dead();
    }
}

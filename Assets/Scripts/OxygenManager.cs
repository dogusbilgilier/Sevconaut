using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class OxygenManager : MonoBehaviour
{
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
        player = Player.inst;
        fillValue = player.oxygen / 100f;
    }
    public void Drowning()
    {

        player.oxygen -= drowningSpeed * Time.deltaTime; ;
        fillValue = player.oxygen / 100f;
        oxygenBar.fillAmount = Mathf.Lerp(oxygenBar.fillAmount, fillValue, 0.05f);

        if (player.oxygen <= 0)
        {
            Debug.Log("Dead");
        }

    }

    public void OxygenTaken()
    {
        player.oxygen += 20f;
        player.oxygen = Mathf.Clamp(player.oxygen, 0, 100);
    }

    private void Update()
    {
        Drowning();
    }
}

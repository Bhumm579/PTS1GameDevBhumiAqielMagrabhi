using UnityEngine;

public class EnemyChildren : Enemy
{
    public override void Serang()
    {
        Debug.Log("Enemy Children Menyerang");
    }

    public override void PerilakuAttack()
    {
        Debug.Log("Enemy Children sedang ATTACK");
    }
}
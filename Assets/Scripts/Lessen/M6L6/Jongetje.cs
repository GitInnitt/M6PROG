using UnityEngine;

public class Jongetje : BattleEnemy
{
    private void Start()
    {
        gameObject.name = "Jongetje";
        health = 150f;
    }


    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage * 0.5f);
        health += 3f;

        Debug.Log($"Jongetje krijgt {damage * 0.5f} damage! Maar krijgt {health += 3f} HP erbij HP: {health}");
        if (health <= 0)
            Die();

    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Jongetje slaat {target.name} met zijn Stokje!!!!");
    }


}
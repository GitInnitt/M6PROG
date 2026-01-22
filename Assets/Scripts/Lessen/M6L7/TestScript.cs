using UnityEngine;
public bool IsPlayerReadyToAttack(Player player)
{
    // Level 1
    if (player == null) return false;
    if (!player.IsAlive) return false;
    if (player.AttackCooldown > 0) return false;

    // Level 2
    if (player.Target == null) return false;
    if (!player.Target.IsAlive) return false;

    // Level 3
    float distance = Vector3.Distance(
        player.transform.position,
        player.Target.transform.position
    );

    if (distance >= 5f) return false;

    // Level 4
    bool canAttackByMana =
        player.Mana >= 20 && player.WeaponEquipped;

    bool canAttackByBuff =
        player.Health > 30 && player.HasBuff("Strength");

    if (!canAttackByMana && !canAttackByBuff) return false;

    // Level 5
    if (player.IsStunned) return false;
    if (player.IsSlowed) return false;

    return true;
}

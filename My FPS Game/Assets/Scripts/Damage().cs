using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // The amount of health each tank starts with
    public int m_StartingHealth = 20;
    private float m_CurrentHealth;
    private bool m_Dead;

    private void OnEnable()
    {
        // when the tank is enabled, reset the tank's health and whether
        // or not it's dead
        m_CurrentHealth = m_StartingHealth;
        m_Dead = false;
        SetHealthUI();
    }

    private void SetHealthUI()
    {
        // TODO: Update the user interface showing the tank’s health
    }
    public void TakeDamage(float amount)
    {
        // Reduce current health by the amount of damage done
        m_CurrentHealth -= amount;
        // Change the UI elements appropriately
        SetHealthUI();
        // if the current health is at or below zero and it has not yet
        // been registered, call OnDeath
        if (m_CurrentHealth <= 0f && !m_Dead)
        {
            OnDeath();
        }
    }
    private void OnDeath()
    {
        // Set the flag so that this function is only called once
        m_Dead = true;
        gameObject.SetActive(false);
    }
}

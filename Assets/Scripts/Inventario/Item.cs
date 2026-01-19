using System;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;


[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    [Header("UI")]
    public Sprite image;
    public bool stackable = true; //por si hay q acumular objetos

    [Header("Gameplay")]
    public ItemType type;
    public ActionType actionType;
    
}

public enum ItemType
{
    Objeto,
    Arma
}

public enum ActionType //estos son ejempñlos
{
    Disparar,
    Cortar
}

using System;

public abstract class IWeaponComponent
{
    public T Decorate<T>(string Text) where T : IWeaponComponent =>
            (T)Activator.CreateInstance(typeof(T), new object[]{this, Text});
}
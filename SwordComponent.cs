public abstract class SwordComponent : IWeaponComponent
{
    protected SwordComponent WeaponComponent;

    public SwordComponent(SwordComponent component) =>
        this.WeaponComponent = component;
    
    public virtual new string ToString() => WeaponComponent.ToString();
}
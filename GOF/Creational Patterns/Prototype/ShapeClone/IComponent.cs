namespace ShapeClone;

public interface IComponent
{
    void Render();
    IComponent Clone();

}
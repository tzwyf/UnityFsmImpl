
public interface IFsmNode
{
    public void OnEnter();
    public void OnExit();
    public void OnUpdate();
    public void OnFixUpdate();
    public void OnHandleMsg();
}

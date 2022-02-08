namespace Net011
{
    public interface IVersionable
    {
        byte[] GetVersion();
        void SetVersion(byte[] version);
    }
}

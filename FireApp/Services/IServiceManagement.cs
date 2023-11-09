namespace FireApp.Services
{
    public interface IServiceManagement
    {
        void SendEMail();
        void UpdateDatabase();
        void GenerateMerchanise();
        void SyncData();
    }
}

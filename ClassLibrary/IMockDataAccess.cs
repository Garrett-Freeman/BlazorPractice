namespace ClassLibrary
{
    public interface IMockDataAccess
    {
        Task<List<TableModel>> GetDataAsync();
    }
}
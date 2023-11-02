namespace RazorClassLibrary;

public interface IMockDataAccess
{
    Task<List<TableModel>> GetDataAsync();
}
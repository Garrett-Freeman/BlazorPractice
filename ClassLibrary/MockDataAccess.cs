using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary;

public class MockDataAccess : IMockDataAccess
{
    public async Task<List<TableModel>> GetDataAsync()
    {
        var data = new List<TableModel>();

        data.Add(new TableModel
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith",
            Email = "John.Smith@outlook.com"
        });

        data.Add(new TableModel
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith",
            Email = "John.Smith@outlook.com"
        });

        data.Add(new TableModel
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith",
            Email = "John.Smith@outlook.com"
        });

        return data;
    }
}

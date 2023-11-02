using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary;

public class MockDataAccess : IMockDataAccess
{
    public async Task<List<TableModel>> GetDataAsync()
    {
        var data = new List<TableModel>();

        data.Add(new TableModel
        {
            Id = 1,
            FirstName = "Tony",
            LastName = "Stark",
            Email = "Iron.Man@starkindustries.com"
        });

        data.Add(new TableModel
        {
            Id = 2,
            FirstName = "Peter",
            LastName = "Parker",
            Email = "Peter.Parker@spiderman.com"
        });

        data.Add(new TableModel
        {
            Id = 3,
            FirstName = "Stephen",
            LastName = "Strange",
            Email = "Dr.Strange@SorcererSupreme.com"
        });

        return data;
    }
}

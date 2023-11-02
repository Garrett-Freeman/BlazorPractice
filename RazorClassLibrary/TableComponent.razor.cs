using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary;

partial class TableComponent
{
    [Parameter]
    public List<TableModel> Data { get; set; }
}


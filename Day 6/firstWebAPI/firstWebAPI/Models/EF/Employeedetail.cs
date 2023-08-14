using System;
using System.Collections.Generic;

namespace firstWebAPI.Models.EF;

public partial class Employeedetail
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesigantion { get; set; }

    public int? EmpSalary { get; set; }

    public bool? EmpIsPermenant { get; set; }
}

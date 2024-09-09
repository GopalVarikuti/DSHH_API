using System;
using System.Collections.Generic;

namespace DSHH_API.Models;

public partial class Stat
{
    public string? Description { get; set; }

    public int? Noofevents { get; set; }

    public int? Volunteers { get; set; }

    public int? Helpedbypeople { get; set; }

    public string? Amountcollected { get; set; }
}

using System;
using System.Collections.Generic;

namespace Cnc.Data.Models;

public partial class Campaign
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual User User { get; set; } = null!;
}

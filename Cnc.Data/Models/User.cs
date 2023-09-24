using System;
using System.Collections.Generic;

namespace Cnc.Data.Models;

public partial class User
{
    /// <summary>
    /// Currently handled by Firebase Auth
    /// </summary>
    public string Id { get; set; } = null!;

    public string? Username { get; set; }

    public virtual ICollection<Campaign> Campaigns { get; set; } = new List<Campaign>();
}

using System;
using System.Collections.Generic;

namespace Lesson1_EFCore_DBLibrary_;

public partial class VProductAndDescription
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string ProductModel { get; set; } = null!;

    public string CultureId { get; set; } = null!;

    public string Description { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPortfolioBE.Domain.Entities;

public class Skill : BaseEntity
{
    public string? Title { get; set; }
    public int? Value { get; set; }
    public Skill()
    {
    }
    public Skill(string title, int value)
    {
        Title = title;
        Value = value;
    }
}

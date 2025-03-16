using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPortfolioBE.Domain.Entities;

public class SocialMedia : BaseEntity
{
    public string? Title { get; set; }
    public string? Icon { get; set; }
    public string? Link { get; set; }
    public SocialMedia()
    {
    }
    public SocialMedia(string title, string icon, string link)
    {
        Title = title;
        Icon = icon;
        Link = link;
    }
}

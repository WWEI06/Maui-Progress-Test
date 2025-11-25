using System.Collections.ObjectModel;
using ProgressTestMAD.Models;

namespace ProgressTestMAD.ViewModels;

public class MainPageViewModel
{
    public ObservableCollection<Artwork> Artworks { get; } = new()
    {
        new Artwork{ Image = "drawone.jpeg", Title = "Peach Tree in Blossom", Price = "$950,000" },
        new Artwork{ Image = "drawtwo.jpeg", Title = "Cafe Terrace at Night", Price = "$1,920,000" },
        new Artwork{ Image = "drawthree.jpeg", Title = "Wheatfield with Crows", Price = "$1,250,000" },
        new Artwork{ Image = "drawfour.jpeg", Title = "Starry Night", Price = "$2,500,000" },
        new Artwork{ Image = "drawfive.jpeg", Title = "Sunflowers", Price = "$1,100,000" },
        new Artwork{ Image = "drawsix.jpeg", Title = "Irises", Price = "$1,045,000" },
        new Artwork{ Image = "drawseven.jpeg", Title = "The Bedroom", Price = "$870,000" }
    };
}
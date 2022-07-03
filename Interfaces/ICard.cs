using BlazorProject.Models;

namespace BlazorProject.Interfaces
{
    public interface ICard 
    {
        List<CardModel> GetCards();
    }
}

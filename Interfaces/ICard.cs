using BlazorProject.Models;

namespace BlazorProject.Interfaces
{
    public interface ICard 
    {
        /// <summary>
        /// Method to get cards
        /// </summary>
        /// <returns>
        /// Returns list of all cards
        /// </returns>
        List<CardModel> GetCards();
    }
}

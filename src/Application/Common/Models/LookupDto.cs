namespace Zeira.Application.Common.Models;

public class LookupDto
{
    public int Id { get; init; }

    public string? Title { get; init; }

    private class Mapping : Profile
    {
        /// <summary>
        /// Initializes the AutoMapper profile used to configure mappings for LookupDto.
        /// </summary>
        public Mapping()
        {
         
        }
    }
}

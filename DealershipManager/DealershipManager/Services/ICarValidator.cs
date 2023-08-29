using DealershipManager.Dtos;

namespace DealershipManager.Services
{
    public interface ICarValidator
    {
        bool Is(AddCarDto carDto);
        bool IsValidAddCarDto(AddCarDto carDto);

        bool IsValidUpdateCarDto(UpdateCarDto carDto);
    }
}

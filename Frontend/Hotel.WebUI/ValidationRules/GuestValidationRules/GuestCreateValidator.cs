using FluentValidation;
using Hotel.WebUI.Dtos.GuestDto;

namespace Hotel.WebUI.ValidationRules.GuestValidationRules
{
    public class GuestCreateValidator:AbstractValidator<GuestCreateDto>
    {

        public GuestCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez");

            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad en kısa 2 karakter olabilir");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Soyad en kısa 2 karakter olabilir");
            RuleFor(x => x.Name).MinimumLength(4).WithMessage("Şehir en kısa 4 karakter olabilir");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Ad en fazla 20 karakter olabilir");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Soyad en fazla 20 karakter olabilir");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Şehir en fazla 20 karakter olabilir");


        }

    }
}

using ElevatorProject.WebUI.DTOs.OfferDTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorProject.WebUI.ValidationRules
{
    public class CreateOfferValidator : AbstractValidator<AddOfferDto>
    {
        public CreateOfferValidator()
        {
            RuleFor(x => x.BuildingName).NotEmpty().WithMessage("Bina Adı alanı boş geçilemez");
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("İsim-Soyisim alanı boş geçilemez");
            RuleFor(x => x.NumberOfFloor).NotEmpty().WithMessage("Kat sayısı boş geçilemez");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş geçilemez");
            RuleFor(x => x.PhoneNumber).MaximumLength(14).WithMessage("Telefon numarası kontrol ediniz");
            RuleFor(x => x.PhoneNumber).MinimumLength(10).WithMessage("Telefon numarası kontrol ediniz");

            RuleFor(x => x.Mail).NotEmpty().WithMessage("EMail boş geçilemez").EmailAddress();     
            RuleFor(x => x.Adress1).MinimumLength(3).WithMessage("Lütfen tam adres giriniz");
            RuleFor(x => x.Adress2).MaximumLength(10).WithMessage("Lütfen en fazla 10 karakter veri girişi yapınız");
           
        }
    }
}

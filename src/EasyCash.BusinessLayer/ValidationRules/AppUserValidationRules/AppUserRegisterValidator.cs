using EasyCash.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;

namespace EasyCash.BusinessLayer.ValidationRules.AppUserValidationRules;

public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
{
    public AppUserRegisterValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Olamaz !");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Olamaz !");
        RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Olamaz !");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Olamaz !");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Olamaz !");
        RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Olamaz !");
        RuleFor(x => x.Name).MaximumLength(30).WithMessage("İsim Alanı En Fazla 30 Karakter Olmalıdır !");
        RuleFor(x => x.Name).MinimumLength(2).WithMessage("İsim Alanı En Az 2 Karakter Olmalıdır !");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email Adres Alanı Boş Olamaz !");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email Adresini Kontrol Ediniz !");
        RuleFor(x => x.ConfirmPassword).Equal(x=>x.Password).WithMessage("Şifreler Uyuşmamaktadır !");
    }
}

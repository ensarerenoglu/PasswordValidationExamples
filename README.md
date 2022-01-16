# PasswordValidationExamples
Password Validation with string extension methods
- PasswordExtensionProject isimli projede 
  - Validation koşulu olarak eklenmek istenen her koşul için IPasswordValidation interface'i kalıtım alınarak yeni bir class oluşturulur. 
  - Bu class içerisinde koşullara eklenecek method doldurulur. 
  - Son olarak Password Validation class'ı içerisinde yer alan ValidatorList() methoduna eklenir. 
 - UnluCo.Education.ExtensionMethods isimli projede (Factory pattern kullanılmıştır. )
  - Oluşturulmak istenen koşullar ICustomPasswordValidator interface'i kalıtım alınarak yeni bir class oluşturularak yazılır. 
  - Oluşturulan class'ın ismine karşılık gelen bir ifade ValidatorsEnum'ına eklenir.
  - Validation Utils class'ı içerisindeki methodun parametresi ValidatorsEnum.YeniClass olarak değiştirilir. 
  - ValidatorFactory içerisinde yer FactoryMethoda yeni bir case eklenir. 

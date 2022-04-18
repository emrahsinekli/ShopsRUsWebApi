# ShopsRUsWebApi

# ShopsRUs WebApi Bilgileri

- Bu proje Monolitik Mimari kullanılarak .Net Framework ortamında geliştirilmiştir. Bu WebApi projesi 4 katmandan oluşmaktadır;

![image](https://user-images.githubusercontent.com/98356742/163841088-029a0113-b5ab-4c0a-acb9-7d7e7d66fce7.png)

--> ShopsRUs.Api(.Net Framework 4.7.2) Katmanı

- WebApi projesinin Startup projesidir. HomeController içinde bulunan endpointlere RESTful isteklerinde bulunabilisiniz. HomeController içinde 2 adet endpoint bulunmaktadır.
- GetAllInvoice(HttpGet) tüm Invoice'leri JSON formatında döndürür.
- ApplyDiscount(billNumber)(HttpPost) İndirim uygulanacak billNumber verildiğinde indirimi uygulayıp Invoice'in son fiyatı geri dönderir.

--> ShopsRUs.DAL(.Net Framework 4.7.2) Katmanı

- WebApi projesinin Data Access Katmanıdır. Code First yaklaşımı kullanılarak. Migration uygulanarak veritabanında tablo configurasyonları gerçekleştirilmiştir.
- Bu uygulamayı bilgisayarınızda çalıştırmak isterneniz Migration!u aktif edip sonrasında ise database'inizi update etmelisiniz. İleride detaylı açıklama mevcuttur.

--> ShopsRUs.Domains(.Net Framework 4.7.2) Katmanı

- Prode'de ve veritabanında kullanılan modeller bu katmanda oluşturulmuştur. Şuan projede sadece Entitiy modeller olarak oluşturuldu ileride mapping kullanılarak DTO
- modellerde oluşturulabilinir.

--> ShopsRUs.Moq(.Net Framework 4.7.2) Katmanı

- Projenin Test katmanıdır. Şuan sadece GetAllInvoice endpointi için kullanılıyor.

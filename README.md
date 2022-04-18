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
- Migration ile MSSql veritabanına Database ve tabloları oluşturup içinde default olarak dataları insert etmektedir.
- Bu uygulamayı bilgisayarınızda çalıştırmak isterneniz Migration!u aktif edip sonrasında ise database'inizi update etmelisiniz. İleride detaylı açıklama mevcuttur.

--> ShopsRUs.Domains(.Net Framework 4.7.2) Katmanı

- Prode'de ve veritabanında kullanılan modeller bu katmanda oluşturulmuştur. Şuan projede sadece Entitiy modeller olarak oluşturuldu ileride mapping kullanılarak DTO
- modellerde oluşturulabilinir.

--> ShopsRUs.Moq(.Net Framework 4.7.2) Katmanı

- Projenin Test katmanıdır. Şuan sadece GetAllInvoice endpointi için kullanılıyor.


# ShopsRUs WebApi Projesini Çalıştırmak
1. Projedeki katmanların App.config ve Web.config dosyalarında bulunan connectionString alanındaki Server isimlerine '.' değerini vererek default olarak var olan Server'da oluşturulmasını sağladım. Herhangi bir problemde ilk olarak Server isimlerini kontrol edebilirsiniz.

2. ShopsRUs.DAL Katmanına gelip Projeyi Set up Startup Projet'i seçmeli ve ardından Package Manager Console'dan 'update-database' komutunu çalıştırmalısınız.
Bu komut veritabanınıza Migration ile Database ve tabloları oluşturacaktır.

3. Ardından ShopsRUs.Api projesini tekrardan Startup projesi olarak seçip çalıştırabilirsiniz.

4. Proje ayağa kalktığında '/swagger' ile swagger ekranına ulaşabilirsiniz. (https://localhost:44303/swagger/ui/index#/Home) 

UML Class Diagram projenin içinde yer almaktadır. (https://github.com/emrahsinekli/ShopsRUsWebApi/blob/master/UML%20Class%20Diagram.jpg)

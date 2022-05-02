1.	MVC uygulaması içerisinde 	Web APİ servisi kullanılmıştır(Hem MVC   hem de Web Api aynı projeye eklendi).
2.	Verileri dış dünyaya taşıyabilmek için(herhangi bir android uygulaması ya da başka bir platforma)  uygulamaya “ InvitationController” adında bir  Web Api Controller’ı eklendi.
3.	“ InvitationController”da  “GetAttendees” action metodu oluşturuldu.Uygulamaya adres çubuğundan(url’den)
“https://localhost:44303/api/Invitation/GetAttendeesocalhost” şeklinde istekte bulunduğunda; “JoiningCase==true” olan katılımcıların  bilgileri kullanıcıya sırasıyla Xml ve Json tipinde sunuldu.

4.	Api controller(InvitationController) Postman uygulaması aracığıyla test edildi.
5.	Veriler Postman uygulaması aracığıyla Json ve Xml tipinde alındı.
6.	MVC ve Web Api uygulamaları aracılığıyla veriler sanal veritabanına(Database.cs)  aktarıldı ve bu bilgilere hem MVC hem de Web Api(Servis) aracılığıyla ulaşma durumu test edildi.
7.	Jquery kullanılarak Web Api üzerinden kayıt eklendi.
8.	Html tabanlı bir form uygulaması(InvitationForm.html) projeye eklendi. Böylece oluşturulan WebApi’den geriye dönen  Json tipi veri uygulamada kullanıldı ve Web Api uygulamasına veri gönderildi. 
9.	Jquery ajax kullanılarak Web Api üzerinden kayıt sorgulama işlemi yapıldı.


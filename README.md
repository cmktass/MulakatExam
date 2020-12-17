# MulakatExam

Aşağıdaki gereksinimlere göre bir API tasarlayın ve proje haline getirin:
•	API, Veri kümelerinin tamamını okuyabilmeli ve aynı anda sadece biri üzerinden işlem yapmalıdır. (veri kümeleri ekte paylaşılmıştır “xml, csv”)
•	API, Verileri JSON tipinde ekrana çıkarmalıdır. 
•	API, kayıtları bir veya daha fazla alana göre filtreleme ve sıralama becerisi sağlamalıdır (ör. Şehre göre filtreleme veya Bölgeye göre sıralama ASC / DESC)
•	API 2 veri kümesini desteklemelidir: CSV ve XML. Ancak yeni veri kümeleri eklenmek istediğinde kolay bir geliştirme olanağı sağlanmalıdır (ör. JSON)

XML veri kümesi için veri biçimi özellikleri eklenmiştir (schema.xsd)

Tavsiyeler:
•	Dosyalar çalışma esnasında upload edilmemelidir, projeye Solution Explorer üzerinden direkt olarak eklenebilir, upload edilmesine gerek yoktur.
•	Veri kümeleri için Interface oluşturulmalı
•	API dönüş tipi JSON olmalıdır
•	Varsayılan olarak hangi veri kümesinden beslenmesi gerektiği web.config dosyasında bir konfigürasyon olarak tutulabilir
•	Ek bir API metodu aracılığı ile varsayılan veri kümesini değiştirebilir. (ör. XML iken JSON ‘a çevirebilir. Bu sayede veri kaynağı JSON dosyası olacaktır.)

Çözümünüz ile ilgili aşağıdaki soruları cevaplandırın:
•	API tasarımınız ile ilgili bilgi paylaşabilir misiniz ?
•	Proje mimarisinda yaptığınız değişiklikler, design pattern’lar ile ilgili bilgi verebilir misiniz?
•	Kullandığınız 3. Parti kütüphaneleri söyleyip işlevleri hakkında bilgi paylaşabilir misiniz?

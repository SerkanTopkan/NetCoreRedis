# NetCoreRedis
Net 6 ile Redis Cache Kullanımı


Docker üzerinde Redis ayağa kaldırıyor ve Api üzerinde CRUD işlemler gerçekleştiriyoruz.

Öncelikle https://docs.docker.com/desktop/windows/install/ adresinden yönergeleri takip ederek Windows bilgisayarımıza docker indirip kuruyoruz.

Terminal ekranı üzerinden "docker pull redis" komutu ile redis image dosyasını pcmize çekiyoruz.

Ardından yine terminal ekranı üzerinde "docker run --name redis -d -p 6379:6379 redis" komutunu girerek mongodb containerımızı ayağa kaldırıyoruz.


Ardından uygulamayı ayağa kaldırıp, https://localhost:7079/swagger/index.html üzerinden apimizi test edebiliriz.

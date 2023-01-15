# Tanks_War_Project
#	TANKS WAR

NASIL OYNANIR?

Tanks War oyunu unity ile geliştirilmiş iki kişilik  savaş oyunudur.
Oyunda bir ana menü ve iki sahneli (bölümlü) bir yapıdadır.
Oyuna ilk girildiğinde ana menude :

  -contiune <br/>
  -new game <br/>
  -quit  <br/>
          seçenekleri vardır.
Oyuna "new game" butonuna tıklayarak başlayabilirsiniz.
Oyunun herhangi bir kısmında oyunu durdurmak istediğinizde "esc" tuşuna basarak durdurabilirsiniz.
Durdurulduğunda menü seçenekleri geliyor:

  -resume <br/>
  -restart <br/>
  -main menu  <br/>
 
   seçeneklerinden birisini seçebilirisiniz.

"Resume" butonuna tıklanıldığında oyuna kalındığı yerden devam edebilirisiniz.
"Restart" butonuna tıklanıldığında oyunu yeniden tekrardan başlatabilirisiniz.
"Main Menu" butonuna tıklanıldığında ana menüye direk geçebilirisiniz.

Oyunda her oyuncuya 1.bölümde 3 can hakkı ve 2. bölümde 3 can hakkı  veriliyor.
Oyuncular birbirine ateş ederek canlarını sıfır yapana kadar devam ediyor.
Her oyuncu için  5 saniyede  bir ateş etme hakkı mevcuttur.
Tanklar oyuna başlarken 7 birim hızla başlıyor .
Verilen bufferlar sayesinde can artırma ve hızlanma seçenekleri vardır.
Oyunda 2 çeşit buffer mevcut:
  - Tankı hızlandırma (her bufferda 5 birim hızlanma) <br/>
  - Can artırma <br/>
  
  
TUŞLAR 

W-A-S-D  --> 1.OYUNCU İÇİN HAREKET  TUŞLARI <br/>
Q-E    --> 1. OYUNCU İÇİN TARET DÖNDÜRME <br/>
SPACE(BOŞLUK) -->1. OYUNCU İÇİN  ATEŞ ETME <br/>
İLERİ -GERİ -SAĞ-SOL  YÖN TUŞLARI--> 2. OYUNCU İÇİN HAREKET TUŞLARI <br/>
NUMPAD 1 - NUMPAD 3 TUŞLARI --> 2.. OYUNCU İÇİN TARET DÖNDÜRME <br/>
NUMPAD 2 -->2. OYUNCU İÇİN ATEŞ ETME <br/>
!! 2. oyuncuda numpad olmayan cihazlar için "j" ve "l" tuşları ile taret döndürme "k" ile ateş etme <br/>

GELİŞTİRDİĞİM KISIMLAR
-Ana menü oluşturuldu. <br/>
-Sahne sayısı 2'ye çıkarıldı.(Sahneler arası asenkron geçiş) <br/>
-Oyun kayıt altına alındı(Kalındığı yerden devam ediyor.) <br/>
-Oyunda  animasyonlR mevcut.(Main menude iki tankın yukarı aşağı gelmesi  oyunda bufferların dönüşü ve patlama )<br/>
-Oyunda sahneler arası geçişte müzikte durdurma olmadan devam ediyor. <br/>
-Oyuncular ateş etme tuşlarına bastığında ateş etme efektleri devreye giriyor. <br/>




OYUN LİNKİ
https://emirhanbalci.itch.io/tanks-game <br/>

OYUNDA KULLANILAN ASSETLERİN LİNKLERİ
main menu asset:https://www.freepik.com/free-photo/cruel-war-scenes-digital-painting_15174538.htm#query=war%20background&position=2&from_view=search&track=sph <br/>

tank asset: https://www.turbosquid.com/3d-models/tank-model-1684359 <br/>

rock asset: https://ambientcg.com/view?id=3DRock004 <br/>

ground: https://ambientcg.com/view?id=Rock030  <br/>

tank texture: https://ambientcg.com/view?id=Metal010 <br/>
 
tree asset: https://www.turbosquid.com/3d-models/3d-model-tree-collection-1980726 <br/>

explosion animation : https://github.com/Tvtig/RocketLauncher/blob/main/Assets/Tvtig/Rocket%20Launcher/Art/Textures/Explosion/Explosion.tif <br/> 

OYUN İÇİ GÖRSELLER

MAIN MENU

<img width="400" alt="Ekran görüntüsü 2023-01-15 145303" src="https://user-images.githubusercontent.com/75940377/212541110-1453f6d9-6425-4d0c-9ea7-a6ab8362ed53.png">

1.SAHNE(BOLUM)

<img width="400" alt="Ekran görüntüsü 2023-01-15 145439" src="https://user-images.githubusercontent.com/75940377/212541115-a5165be6-a724-47a8-b219-44b44d30a7fc.png">

2.SAHNE(BOLUM)

<img width="400" alt="Ekran görüntüsü 2023-01-15 145737" src="https://user-images.githubusercontent.com/75940377/212541119-7d6ee0ad-5e8b-4fe5-a24a-44bb060d79bf.png">


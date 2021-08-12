# SpaceShip_VR
우주선 VR 콘텐츠
--------------
## 1. 설명
  * 우주선 운행 VR 게임으로 시선을 인식해서 우주선을 이동시키는 것이 가능
  * 이동 중에 운석이 등장하는 데, 운석과 충돌을 통해서 해당 운석을 부실 수 있다.
  * 참고로 Asset은 혹시나 발생 가능한 저작권 문제로 깃에 올리지 않았습니다.
-------------
## 2. 개발 환경
  * Unity 2019.3.13f1
  * Android 기반
    * 7.0 Nougat
----------------
## 3. 주의사항 및 참고
  * XR settings -> Virtual Reality Supported 체크하고 Cardboard 확인
  * Other settings -> Graphics APIs -> Vulkan 있는지 확인하고 있다면 제거
  * Other settings -> Scripting Backend ->IL2CPP로 변경
  * Resolution and Presentation -> Default Orientation -> LandScape Left 설정
    * 해당 기능으로 자동 가로 고정이 되도록 설정 가능
------------------
## 4. Scene
  * Menu : 게임을 하러 갈지, 우주 배경을 변경할지 선택
  * InGame : 첫 번째 배경으로 플레이
  * Ingame2 : 두 번째 배경으로 플레이
  * Select : 우주 배경을 선택 가능
------------------
## 5. 참고 이미지
  * 메뉴창
  ![KakaoTalk_20210711_004701952_03](https://user-images.githubusercontent.com/67555400/125169062-7a437880-e1e3-11eb-85e3-d444b8b643da.jpg)
  * 우주 배경 선택 창
  ![KakaoTalk_20210711_004701952](https://user-images.githubusercontent.com/67555400/125169102-a8c15380-e1e3-11eb-8cac-85746b8428d0.jpg)
  * 플레이 창
  ![KakaoTalk_20210711_004701952_02](https://user-images.githubusercontent.com/67555400/125169077-89c2c180-e1e3-11eb-9c8b-4cc1c9ee959d.jpg)
  ![KakaoTalk_20210711_004701952_01](https://user-images.githubusercontent.com/67555400/125169085-98a97400-e1e3-11eb-9421-141a463ac746.jpg)

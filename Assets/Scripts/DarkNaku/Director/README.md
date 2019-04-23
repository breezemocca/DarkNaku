# Director

## 설명
로딩 Scene을 포함하여 Unity Scene 사이의 전환을 관리하는 Singleton MonoBehaviour 기반의 클래스 입니다.

## 클래스

### Director

Inherits from : SingletonMonobehaviour

### 속성

**public static string LoadingSceneName;**

로딩 Scene의 이름

**public static bool IsChanging;**

Scene 전환이 진행 중인지 확인 (읽기전용)

### 함수

**public static void ChangeScene(string loadingSceneName, string nextSceneName, float endureTime = 0F);**

Scene 전환 함수

loadingSceneName : 로딩 Scene 이름이며 호출시 LoadingSceneName에 저장됩니다.

nextSceneName : 다음 Scene 이름

endureTime : Scene 전환시 최소 이 시간만큼은 유지 후에 전환 됩니다. 기본값은 0초 입니다.

**public static void ChangeScene(string nextSceneName, float endureTime = 0F)**

LoadingSceneName을 미리 설정 후에 호출해야 합니다.

nextSceneName : 다음 Scene 이름

endureTime : Scene 전환시 최소 이 시간만큼은 유지 후에 전환 됩니다. 기본값은 0초 입니다.

#### 이벤트


## 개발 예정 기능

* 로딩 화면부터 시작할 수 있도록

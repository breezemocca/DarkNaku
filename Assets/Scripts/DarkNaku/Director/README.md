# Director



#### 설명

로딩 Scene을 포함하여 Unity Scene 사이의 전환을 관리하는 Singleton MonoBehaviour 기반의 클래스 입니다.



## 클래스



### Director

Inherits from : SingletonMonobehaviour\<T>



### 속성



**public static string LoadingSceneName;**

로딩 Scene의 이름



**public static bool IsChanging;**

Scene 전환이 진행 중인지 확인 (읽기전용)



### 함수



**public static void ChangeScene(string loadingSceneName, string nextSceneName, float endureTime = 0F);**

Scene 전환을 실행하는 함수

loadingSceneName : 로딩 Scene 이름이며 호출시 LoadingSceneName에 저장됩니다.

nextSceneName : 다음 Scene 이름

endureTime : Scene 전환시 최소 이 시간만큼은 유지 후에 전환 됩니다. 기본값은 0초 입니다.



**public static void ChangeScene(string nextSceneName, float endureTime = 0F)**

Scene 전환을 실행하는 함수. LoadingSceneName을 미리 설정 후에 호출해야 합니다.

nextSceneName : 다음 Scene 이름

endureTime : Scene 전환시 최소 이 시간만큼은 유지 후에 전환 됩니다. 기본값은 0초 입니다.



## 인터페이스



### ISceneHandler

Scene 전환시 이벤트에 대한 인터페이스 입니다. Hierarchy 최상단에 있는 GameObject들 중에서 검색하여 해당 인터페이스를 상속 받은 컴포넌트가 있는 경우 이벤트 함수가 호출 됩니다. 상속받은 컴포넌트가 여러개여도 가장 먼저 검색된 하나만 호출됩니다.



### 이벤트



**void OnStartOutAnimation();**

현재 Scene을 대상으로 화면을 나가는 로딩 연출이 시작될 때 발생합니다. 



**void OnUnloadScene();**

현재 Scene을 대상으로 로딩 Scene Load와 연출이 끝난 후 현재 Scene의 Unload 직전에 발생합니다. 



**void OnLoadScene();**

다음 Scene을 대상으로 Load 완료 후 화면을 진입하는 연출 시작 전에 발생합니다.



**void OnEndInAnimation();**

다음 Scene을 대상으로 진입 연출이 완료 후 발생합니다.



### ILoader

로딩 Scene의 로딩 연출 및 진행 상황에 대한 이벤트 인터페이스 입니다. Hierarchy 최상단에 있는 GameObject들 중에서 검색하여 해당 인터페이스를 상속 받은 컴포넌트가 있는 경우 이벤트 함수가 호출 됩니다. 상속받은 컴포넌트가 여러개여도 가장 먼저 검색된 하나만 호출됩니다.



### 이벤트



**IEnumerator CoInAnimation();**

로딩 화면을 진입하는 연출을 구현하는 이벤트 입니다.



**void OnProgress(float progress);**

Scene전환 진행 상황이 변할 때 0~1 사이의 값으로 발생합니다. (이전 Scene의 해제 과정이 0~0.5이고 다음 씬의 로드에 대한 과정이 0.5~1 입니다.)



**IEnumerator CoOutAnimation();**

로딩 화면에서 빠저나가는 연출을 구현하는 이벤트 입니다.



## 개발 예정 기능

* 로딩 화면부터 시작할 수 있도록
# OVFL Localization

Unity Localization 확장 패키지입니다.  
언어 전환 시 TextMesh Pro 폰트를 자동으로 교체하는 `LocalizeTMPFontEvent` 컴포넌트를 제공합니다.

## 기능

### LocalizeTMPFontEvent

언어가 바뀔 때 TMP_Text에 적용되는 폰트를 자동으로 교체합니다.

#### 설정 방법
1. TMP_Text 컴포넌트가 있는 GameObject에 `LocalizeTMPFontEvent` 추가
2. **Localized Font** 필드에 Unity Localization의 `TMP_FontAsset` 에셋 테이블 연결
3. **On Update Asset** 이벤트에 TMP_Text의 `font` 프로퍼티 연결

언어가 전환될 때마다 에셋 테이블에서 해당 언어의 폰트를 자동으로 불러와 적용합니다.

## 설치 방법

Unity Localization 패키지가 먼저 설치되어 있어야 합니다.

### Package Manager (git URL)
1. **Window > Package Manager** 열기
2. 좌상단 **+** → **Add package from git URL...**
3. 아래 URL 입력:
   ```
   https://github.com/Overflower706/localization.git
   ```

### manifest.json 직접 편집
```json
{
  "dependencies": {
    "com.unity.localization": "1.5.9",
    "com.ovfl.localization": "https://github.com/Overflower706/localization.git"
  }
}
```

## 요구사항

- Unity 6000.1 이상
- com.unity.localization 1.5.9 이상
- TextMesh Pro

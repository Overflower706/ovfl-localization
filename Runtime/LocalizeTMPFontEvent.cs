using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using TMPro;
using System; // TextMeshPro를 쓰기 위해 필수

// 1. LocalizedAsset 클래스를 상속받아 "TMP_FontAsset을 다루겠다"고 정의
[Serializable]
public class LocalizedTMPFont : LocalizedAsset<TMP_FontAsset> { }

// 2. 폰트가 바뀔 때 실행될 UnityEvent 정의
[Serializable]
public class UnityEventTMPFont : UnityEngine.Events.UnityEvent<TMP_FontAsset> { }

// 3. 실제 컴포넌트 정의 (이게 Add Component 메뉴에 뜹니다)
[AddComponentMenu("Localization/Asset/Localize TMP Font Event")]
public class LocalizeTMPFontEvent : LocalizedAssetEvent<TMP_FontAsset, LocalizedTMPFont, UnityEventTMPFont>
{
    // 내용은 비워도 됩니다. 부모 클래스가 다 처리합니다.
}

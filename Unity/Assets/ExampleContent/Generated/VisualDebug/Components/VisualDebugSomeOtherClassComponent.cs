//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public SomeOtherClassComponent SomeOtherClass { get { return (SomeOtherClassComponent)GetComponent(VisualDebugComponentsLookup.SomeOtherClass); } }
    public bool hasSomeOtherClass { get { return HasComponent(VisualDebugComponentsLookup.SomeOtherClass); } }

    public void AddSomeOtherClass(ExampleContent.VisualDebugging.SomeOtherClass newValue) {
        var index = VisualDebugComponentsLookup.SomeOtherClass;
        var component = (SomeOtherClassComponent)CreateComponent(index, typeof(SomeOtherClassComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceSomeOtherClass(ExampleContent.VisualDebugging.SomeOtherClass newValue) {
        var index = VisualDebugComponentsLookup.SomeOtherClass;
        var component = (SomeOtherClassComponent)CreateComponent(index, typeof(SomeOtherClassComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveSomeOtherClass() {
        RemoveComponent(VisualDebugComponentsLookup.SomeOtherClass);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherSomeOtherClass;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> SomeOtherClass {
        get {
            if (_matcherSomeOtherClass == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.SomeOtherClass);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherSomeOtherClass = matcher;
            }

            return _matcherSomeOtherClass;
        }
    }
}

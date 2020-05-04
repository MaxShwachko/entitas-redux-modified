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

    public ExampleContent.VisualDebugging.MyIntComponent MyInt { get { return (ExampleContent.VisualDebugging.MyIntComponent)GetComponent(VisualDebugComponentsLookup.MyInt); } }
    public bool hasMyInt { get { return HasComponent(VisualDebugComponentsLookup.MyInt); } }

    public void AddMyInt(int newMyInt) {
        var index = VisualDebugComponentsLookup.MyInt;
        var component = (ExampleContent.VisualDebugging.MyIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyIntComponent));
        component.myInt = newMyInt;
        AddComponent(index, component);
    }

    public void ReplaceMyInt(int newMyInt) {
        var index = VisualDebugComponentsLookup.MyInt;
        var component = (ExampleContent.VisualDebugging.MyIntComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyIntComponent));
        component.myInt = newMyInt;
        ReplaceComponent(index, component);
    }

    public void RemoveMyInt() {
        RemoveComponent(VisualDebugComponentsLookup.MyInt);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyInt;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyInt {
        get {
            if (_matcherMyInt == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyInt);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherMyInt = matcher;
            }

            return _matcherMyInt;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public TestAnyMultipleEventsStandardEventListenerComponent TestAnyMultipleEventsStandardEventListener { get { return (TestAnyMultipleEventsStandardEventListenerComponent)GetComponent(TestComponentsLookup.TestAnyMultipleEventsStandardEventListener); } }
    public bool hasTestAnyMultipleEventsStandardEventListener { get { return HasComponent(TestComponentsLookup.TestAnyMultipleEventsStandardEventListener); } }

    public void AddTestAnyMultipleEventsStandardEventListener(System.Collections.Generic.List<ITestAnyMultipleEventsStandardEventListener> newValue) {
        var index = TestComponentsLookup.TestAnyMultipleEventsStandardEventListener;
        var component = (TestAnyMultipleEventsStandardEventListenerComponent)CreateComponent(index, typeof(TestAnyMultipleEventsStandardEventListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTestAnyMultipleEventsStandardEventListener(System.Collections.Generic.List<ITestAnyMultipleEventsStandardEventListener> newValue) {
        var index = TestComponentsLookup.TestAnyMultipleEventsStandardEventListener;
        var component = (TestAnyMultipleEventsStandardEventListenerComponent)CreateComponent(index, typeof(TestAnyMultipleEventsStandardEventListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTestAnyMultipleEventsStandardEventListener() {
        RemoveComponent(TestComponentsLookup.TestAnyMultipleEventsStandardEventListener);
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
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherTestAnyMultipleEventsStandardEventListener;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> TestAnyMultipleEventsStandardEventListener {
        get {
            if (_matcherTestAnyMultipleEventsStandardEventListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.TestAnyMultipleEventsStandardEventListener);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherTestAnyMultipleEventsStandardEventListener = matcher;
            }

            return _matcherTestAnyMultipleEventsStandardEventListener;
        }
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
public partial class TestEntity {

    public void AddTestAnyMultipleEventsStandardEventListener(ITestAnyMultipleEventsStandardEventListener value) {
        var listeners = hasTestAnyMultipleEventsStandardEventListener
            ? TestAnyMultipleEventsStandardEventListener.value
            : new System.Collections.Generic.List<ITestAnyMultipleEventsStandardEventListener>();
        listeners.Add(value);
        ReplaceTestAnyMultipleEventsStandardEventListener(listeners);
    }

    public void RemoveTestAnyMultipleEventsStandardEventListener(ITestAnyMultipleEventsStandardEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = TestAnyMultipleEventsStandardEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTestAnyMultipleEventsStandardEventListener();
        } else {
            ReplaceTestAnyMultipleEventsStandardEventListener(listeners);
        }
    }
}

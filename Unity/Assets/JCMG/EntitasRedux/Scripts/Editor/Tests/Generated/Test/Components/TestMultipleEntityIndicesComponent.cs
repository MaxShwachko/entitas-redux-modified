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

    public EntitasRedux.Tests.MultipleEntityIndicesComponent MultipleEntityIndices { get { return (EntitasRedux.Tests.MultipleEntityIndicesComponent)GetComponent(TestComponentsLookup.MultipleEntityIndices); } }
    public bool hasMultipleEntityIndices { get { return HasComponent(TestComponentsLookup.MultipleEntityIndices); } }

    public void AddMultipleEntityIndices(string newValue, string newValue2) {
        var index = TestComponentsLookup.MultipleEntityIndices;
        var component = (EntitasRedux.Tests.MultipleEntityIndicesComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultipleEntityIndicesComponent));
        component.value = newValue;
        component.value2 = newValue2;
        AddComponent(index, component);
    }

    public void ReplaceMultipleEntityIndices(string newValue, string newValue2) {
        var index = TestComponentsLookup.MultipleEntityIndices;
        var component = (EntitasRedux.Tests.MultipleEntityIndicesComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultipleEntityIndicesComponent));
        component.value = newValue;
        component.value2 = newValue2;
        ReplaceComponent(index, component);
    }

    public void RemoveMultipleEntityIndices() {
        RemoveComponent(TestComponentsLookup.MultipleEntityIndices);
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
public partial class TestEntity : IMultipleEntityIndicesEntity { }

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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherMultipleEntityIndices;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> MultipleEntityIndices {
        get {
            if (_matcherMultipleEntityIndices == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.MultipleEntityIndices);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherMultipleEntityIndices = matcher;
            }

            return _matcherMultipleEntityIndices;
        }
    }
}

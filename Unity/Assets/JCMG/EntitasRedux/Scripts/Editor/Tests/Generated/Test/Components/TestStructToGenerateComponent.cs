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

    public StructToGenerateComponent StructToGenerate { get { return (StructToGenerateComponent)GetComponent(TestComponentsLookup.StructToGenerate); } }
    public bool hasStructToGenerate { get { return HasComponent(TestComponentsLookup.StructToGenerate); } }

    public void AddStructToGenerate(EntitasRedux.Tests.StructToGenerate newValue) {
        var index = TestComponentsLookup.StructToGenerate;
        var component = (StructToGenerateComponent)CreateComponent(index, typeof(StructToGenerateComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStructToGenerate(EntitasRedux.Tests.StructToGenerate newValue) {
        var index = TestComponentsLookup.StructToGenerate;
        var component = (StructToGenerateComponent)CreateComponent(index, typeof(StructToGenerateComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStructToGenerate() {
        RemoveComponent(TestComponentsLookup.StructToGenerate);
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

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherStructToGenerate;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> StructToGenerate {
        get {
            if (_matcherStructToGenerate == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.StructToGenerate);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherStructToGenerate = matcher;
            }

            return _matcherStructToGenerate;
        }
    }
}

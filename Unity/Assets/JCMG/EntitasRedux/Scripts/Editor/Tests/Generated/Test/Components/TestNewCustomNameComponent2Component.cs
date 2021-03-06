public partial class TestEntity
{
	public NewCustomNameComponent2Component NewCustomNameComponent2 { get { return (NewCustomNameComponent2Component)GetComponent(TestComponentsLookup.NewCustomNameComponent2); } }
	public bool HasNewCustomNameComponent2 { get { return HasComponent(TestComponentsLookup.NewCustomNameComponent2); } }

	public void AddNewCustomNameComponent2(EntitasRedux.Tests.CustomName newValue)
	{
		var index = TestComponentsLookup.NewCustomNameComponent2;
		var component = (NewCustomNameComponent2Component)CreateComponent(index, typeof(NewCustomNameComponent2Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceNewCustomNameComponent2(EntitasRedux.Tests.CustomName newValue)
	{
		var index = TestComponentsLookup.NewCustomNameComponent2;
		var component = (NewCustomNameComponent2Component)CreateComponent(index, typeof(NewCustomNameComponent2Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyNewCustomNameComponent2To(NewCustomNameComponent2Component copyComponent)
	{
		var index = TestComponentsLookup.NewCustomNameComponent2;
		var component = (NewCustomNameComponent2Component)CreateComponent(index, typeof(NewCustomNameComponent2Component));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveNewCustomNameComponent2()
	{
		RemoveComponent(TestComponentsLookup.NewCustomNameComponent2);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherNewCustomNameComponent2;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> NewCustomNameComponent2
	{
		get
		{
			if (_matcherNewCustomNameComponent2 == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.NewCustomNameComponent2);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherNewCustomNameComponent2 = matcher;
			}

			return _matcherNewCustomNameComponent2;
		}
	}
}

public partial class TestEntity
{
	public EntitasRedux.Tests.StandardEventComponent StandardEvent { get { return (EntitasRedux.Tests.StandardEventComponent)GetComponent(TestComponentsLookup.StandardEvent); } }
	public bool HasStandardEvent { get { return HasComponent(TestComponentsLookup.StandardEvent); } }

	public void AddStandardEvent(string newValue)
	{
		var index = TestComponentsLookup.StandardEvent;
		var component = (EntitasRedux.Tests.StandardEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.StandardEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceStandardEvent(string newValue)
	{
		var index = TestComponentsLookup.StandardEvent;
		var component = (EntitasRedux.Tests.StandardEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.StandardEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyStandardEventTo(EntitasRedux.Tests.StandardEventComponent copyComponent)
	{
		var index = TestComponentsLookup.StandardEvent;
		var component = (EntitasRedux.Tests.StandardEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.StandardEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveStandardEvent()
	{
		RemoveComponent(TestComponentsLookup.StandardEvent);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherStandardEvent;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> StandardEvent
	{
		get
		{
			if (_matcherStandardEvent == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.StandardEvent);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherStandardEvent = matcher;
			}

			return _matcherStandardEvent;
		}
	}
}

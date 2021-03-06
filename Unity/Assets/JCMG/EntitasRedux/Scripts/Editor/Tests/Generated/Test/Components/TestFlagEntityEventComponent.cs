public partial class TestEntity
{
	static readonly EntitasRedux.Tests.FlagEntityEventComponent FlagEntityEventComponent = new EntitasRedux.Tests.FlagEntityEventComponent();

	public bool IsFlagEntityEvent
	{
		get { return HasComponent(TestComponentsLookup.FlagEntityEvent); }
		set
		{
			if (value != IsFlagEntityEvent)
			{
				var index = TestComponentsLookup.FlagEntityEvent;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: FlagEntityEventComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherFlagEntityEvent;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> FlagEntityEvent
	{
		get
		{
			if (_matcherFlagEntityEvent == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.FlagEntityEvent);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherFlagEntityEvent = matcher;
			}

			return _matcherFlagEntityEvent;
		}
	}
}

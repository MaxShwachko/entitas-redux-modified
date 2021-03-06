public partial class TestContext
{
	public TestEntity CustomPrefixFlagEntity { get { return GetGroup(TestMatcher.CustomPrefixFlag).GetSingleEntity(); } }

	public bool MyCustomPrefixFlag
	{
		get { return CustomPrefixFlagEntity != null; }
		set
		{
			var entity = CustomPrefixFlagEntity;
			if (value != (entity != null))
			{
				if (value)
				{
					CreateEntity().MyCustomPrefixFlag = true;
				}
				else
				{
					entity.Destroy();
				}
			}
		}
	}
}

public partial class TestEntity
{
	static readonly EntitasRedux.Tests.CustomPrefixFlagComponent CustomPrefixFlagComponent = new EntitasRedux.Tests.CustomPrefixFlagComponent();

	public bool MyCustomPrefixFlag
	{
		get { return HasComponent(TestComponentsLookup.CustomPrefixFlag); }
		set
		{
			if (value != MyCustomPrefixFlag)
			{
				var index = TestComponentsLookup.CustomPrefixFlag;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: CustomPrefixFlagComponent;

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
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherCustomPrefixFlag;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> CustomPrefixFlag
	{
		get
		{
			if (_matcherCustomPrefixFlag == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.CustomPrefixFlag);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherCustomPrefixFlag = matcher;
			}

			return _matcherCustomPrefixFlag;
		}
	}
}

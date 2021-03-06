public partial class MyTestEntity
{
	static readonly EntitasRedux.Tests.ComponentE ComponentEComponent = new EntitasRedux.Tests.ComponentE();

	public bool IsComponentE
	{
		get { return HasComponent(MyTestComponentsLookup.ComponentE); }
		set
		{
			if (value != IsComponentE)
			{
				var index = MyTestComponentsLookup.ComponentE;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: ComponentEComponent;

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

public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherComponentE;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> ComponentE
	{
		get
		{
			if (_matcherComponentE == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.ComponentE);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherComponentE = matcher;
			}

			return _matcherComponentE;
		}
	}
}

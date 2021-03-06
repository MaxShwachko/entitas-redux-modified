public partial class TestEntity
{
	public StandardEntityEventRemovedListenerComponent StandardEntityEventRemovedListener { get { return (StandardEntityEventRemovedListenerComponent)GetComponent(TestComponentsLookup.StandardEntityEventRemovedListener); } }
	public bool HasStandardEntityEventRemovedListener { get { return HasComponent(TestComponentsLookup.StandardEntityEventRemovedListener); } }

	public void AddStandardEntityEventRemovedListener(System.Collections.Generic.List<IStandardEntityEventRemovedListener> newValue)
	{
		var index = TestComponentsLookup.StandardEntityEventRemovedListener;
		var component = (StandardEntityEventRemovedListenerComponent)CreateComponent(index, typeof(StandardEntityEventRemovedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceStandardEntityEventRemovedListener(System.Collections.Generic.List<IStandardEntityEventRemovedListener> newValue)
	{
		var index = TestComponentsLookup.StandardEntityEventRemovedListener;
		var component = (StandardEntityEventRemovedListenerComponent)CreateComponent(index, typeof(StandardEntityEventRemovedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyStandardEntityEventRemovedListenerTo(StandardEntityEventRemovedListenerComponent copyComponent)
	{
		var index = TestComponentsLookup.StandardEntityEventRemovedListener;
		var component = (StandardEntityEventRemovedListenerComponent)CreateComponent(index, typeof(StandardEntityEventRemovedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveStandardEntityEventRemovedListener()
	{
		RemoveComponent(TestComponentsLookup.StandardEntityEventRemovedListener);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherStandardEntityEventRemovedListener;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> StandardEntityEventRemovedListener
	{
		get
		{
			if (_matcherStandardEntityEventRemovedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.StandardEntityEventRemovedListener);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherStandardEntityEventRemovedListener = matcher;
			}

			return _matcherStandardEntityEventRemovedListener;
		}
	}
}

public partial class TestEntity
{
	public void AddStandardEntityEventRemovedListener(IStandardEntityEventRemovedListener value)
	{
		var listeners = HasStandardEntityEventRemovedListener
			? StandardEntityEventRemovedListener.value
			: new System.Collections.Generic.List<IStandardEntityEventRemovedListener>();
		listeners.Add(value);
		ReplaceStandardEntityEventRemovedListener(listeners);
	}

	public void RemoveStandardEntityEventRemovedListener(IStandardEntityEventRemovedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = StandardEntityEventRemovedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveStandardEntityEventRemovedListener();
		}
		else
		{
			ReplaceStandardEntityEventRemovedListener(listeners);
		}
	}
}

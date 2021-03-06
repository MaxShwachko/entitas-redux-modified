public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent MonoBehaviourSubClass { get { return (ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent)GetComponent(VisualDebugComponentsLookup.MonoBehaviourSubClass); } }
	public bool HasMonoBehaviourSubClass { get { return HasComponent(VisualDebugComponentsLookup.MonoBehaviourSubClass); } }

	public void AddMonoBehaviourSubClass(ExampleContent.VisualDebugging.MonoBehaviourSubClass newMonoBehaviour)
	{
		var index = VisualDebugComponentsLookup.MonoBehaviourSubClass;
		var component = (ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.monoBehaviour = newMonoBehaviour;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMonoBehaviourSubClass(ExampleContent.VisualDebugging.MonoBehaviourSubClass newMonoBehaviour)
	{
		var index = VisualDebugComponentsLookup.MonoBehaviourSubClass;
		var component = (ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.monoBehaviour = newMonoBehaviour;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMonoBehaviourSubClassTo(ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MonoBehaviourSubClass;
		var component = (ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.monoBehaviour = copyComponent.monoBehaviour;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMonoBehaviourSubClass()
	{
		RemoveComponent(VisualDebugComponentsLookup.MonoBehaviourSubClass);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMonoBehaviourSubClass;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MonoBehaviourSubClass
	{
		get
		{
			if (_matcherMonoBehaviourSubClass == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MonoBehaviourSubClass);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMonoBehaviourSubClass = matcher;
			}

			return _matcherMonoBehaviourSubClass;
		}
	}
}

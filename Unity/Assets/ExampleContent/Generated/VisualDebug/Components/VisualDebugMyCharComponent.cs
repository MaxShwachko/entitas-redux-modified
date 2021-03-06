public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.MyCharComponent MyChar { get { return (ExampleContent.VisualDebugging.MyCharComponent)GetComponent(VisualDebugComponentsLookup.MyChar); } }
	public bool HasMyChar { get { return HasComponent(VisualDebugComponentsLookup.MyChar); } }

	public void AddMyChar(char newMyChar)
	{
		var index = VisualDebugComponentsLookup.MyChar;
		var component = (ExampleContent.VisualDebugging.MyCharComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyCharComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myChar = newMyChar;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMyChar(char newMyChar)
	{
		var index = VisualDebugComponentsLookup.MyChar;
		var component = (ExampleContent.VisualDebugging.MyCharComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyCharComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myChar = newMyChar;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMyCharTo(ExampleContent.VisualDebugging.MyCharComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyChar;
		var component = (ExampleContent.VisualDebugging.MyCharComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyCharComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myChar = copyComponent.myChar;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMyChar()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyChar);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyChar;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyChar
	{
		get
		{
			if (_matcherMyChar == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyChar);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyChar = matcher;
			}

			return _matcherMyChar;
		}
	}
}

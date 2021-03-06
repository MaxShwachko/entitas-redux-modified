public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.ColorComponent Color { get { return (ExampleContent.VisualDebugging.ColorComponent)GetComponent(VisualDebugComponentsLookup.Color); } }
	public bool HasColor { get { return HasComponent(VisualDebugComponentsLookup.Color); } }

	public void AddColor(UnityEngine.Color newColor)
	{
		var index = VisualDebugComponentsLookup.Color;
		var component = (ExampleContent.VisualDebugging.ColorComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ColorComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.color = newColor;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceColor(UnityEngine.Color newColor)
	{
		var index = VisualDebugComponentsLookup.Color;
		var component = (ExampleContent.VisualDebugging.ColorComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ColorComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.color = newColor;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyColorTo(ExampleContent.VisualDebugging.ColorComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.Color;
		var component = (ExampleContent.VisualDebugging.ColorComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ColorComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.color = copyComponent.color;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveColor()
	{
		RemoveComponent(VisualDebugComponentsLookup.Color);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherColor;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Color
	{
		get
		{
			if (_matcherColor == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Color);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherColor = matcher;
			}

			return _matcherColor;
		}
	}
}

public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.CustomObjectDictionaryComponent CustomObjectDictionary { get { return (ExampleContent.VisualDebugging.CustomObjectDictionaryComponent)GetComponent(VisualDebugComponentsLookup.CustomObjectDictionary); } }
	public bool HasCustomObjectDictionary { get { return HasComponent(VisualDebugComponentsLookup.CustomObjectDictionary); } }

	public void AddCustomObjectDictionary(System.Collections.Generic.Dictionary<string, ExampleContent.VisualDebugging.CustomObject> newValue)
	{
		var index = VisualDebugComponentsLookup.CustomObjectDictionary;
		var component = (ExampleContent.VisualDebugging.CustomObjectDictionaryComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.CustomObjectDictionaryComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceCustomObjectDictionary(System.Collections.Generic.Dictionary<string, ExampleContent.VisualDebugging.CustomObject> newValue)
	{
		var index = VisualDebugComponentsLookup.CustomObjectDictionary;
		var component = (ExampleContent.VisualDebugging.CustomObjectDictionaryComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.CustomObjectDictionaryComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyCustomObjectDictionaryTo(ExampleContent.VisualDebugging.CustomObjectDictionaryComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.CustomObjectDictionary;
		var component = (ExampleContent.VisualDebugging.CustomObjectDictionaryComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.CustomObjectDictionaryComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = (System.Collections.Generic.Dictionary<string, ExampleContent.VisualDebugging.CustomObject>)JCMG.EntitasRedux.DictionaryTools.DeepCopy(copyComponent.value);
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveCustomObjectDictionary()
	{
		RemoveComponent(VisualDebugComponentsLookup.CustomObjectDictionary);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherCustomObjectDictionary;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> CustomObjectDictionary
	{
		get
		{
			if (_matcherCustomObjectDictionary == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.CustomObjectDictionary);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherCustomObjectDictionary = matcher;
			}

			return _matcherCustomObjectDictionary;
		}
	}
}

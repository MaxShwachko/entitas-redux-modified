/*

MIT License

Copyright (c) 2020 Jeff Campbell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using UnityEditor;

namespace JCMG.EntitasRedux.Blueprints.Editor
{
	[CustomEditor(typeof(BlueprintBehaviourBase), editorForChildClasses:true)]
	internal sealed class BlueprintBehaviourBaseInspector : BlueprintInspector
	{
		private BlueprintBehaviourBase _blueprintBehaviourBase;

		protected override void OnEnable()
		{
			// Get blueprint type info
			_blueprintBehaviourBase = (BlueprintBehaviourBase)target;

			base.OnEnable();
		}

		public override void OnInspectorGUI()
		{
			DrawComponentSelectorGUI(_blueprintBehaviourBase.Components, OnComponentAdded);
			DrawComponentArrayGUI(_blueprintBehaviourBase.Components);
		}

		private void OnComponentAdded()
		{
			_blueprintBehaviourBase.Validate();

			EditorUtility.SetDirty(target);
		}

		protected override void OnComponentRemoved(IComponent component)
		{
			// If the component was removed, set the target as dirty.
			if (_blueprintBehaviourBase.Components.Remove(component))
			{
				_blueprintBehaviourBase.Validate();

				EditorUtility.SetDirty(target);
			}
		}
	}
}

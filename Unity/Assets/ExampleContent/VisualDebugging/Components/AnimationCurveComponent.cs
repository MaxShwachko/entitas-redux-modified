using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace ExampleContent.VisualDebugging
{
	[Serializable]
	[VisualDebug]
	public class AnimationCurveComponent : IComponent
	{
		public AnimationCurve animationCurve;
	}
}

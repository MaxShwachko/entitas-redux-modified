//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class Test2AnyEventToGenerateEventSystem : JCMG.EntitasRedux.ReactiveSystem<Test2Entity> {

    readonly JCMG.EntitasRedux.IGroup<Test2Entity> _listeners;
    readonly System.Collections.Generic.List<Test2Entity> _entityBuffer;
    readonly System.Collections.Generic.List<ITest2AnyEventToGenerateListener> _listenerBuffer;

    public Test2AnyEventToGenerateEventSystem(Contexts contexts) : base(contexts.Test2) {
        _listeners = contexts.Test2.GetGroup(Test2Matcher.Test2AnyEventToGenerateListener);
        _entityBuffer = new System.Collections.Generic.List<Test2Entity>();
        _listenerBuffer = new System.Collections.Generic.List<ITest2AnyEventToGenerateListener>();
    }

    protected override JCMG.EntitasRedux.ICollector<Test2Entity> GetTrigger(JCMG.EntitasRedux.IContext<Test2Entity> context) {
        return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
            context, JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(Test2Matcher.EventToGenerate)
        );
    }

    protected override bool Filter(Test2Entity entity) {
        return entity.hasEventToGenerate;
    }

    protected override void Execute(System.Collections.Generic.List<Test2Entity> entities) {
        foreach (var e in entities) {
            var component = e.EventToGenerate;
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.Test2AnyEventToGenerateListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyEventToGenerate(e, component.value);
                }
            }
        }
    }
}

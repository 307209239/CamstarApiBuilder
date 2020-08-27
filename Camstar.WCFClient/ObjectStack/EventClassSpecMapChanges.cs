// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventClassSpecMapChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class EventClassSpecMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_FailureModeGroup")]
    protected NamedObjectRef _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Subclassification")]
    protected NamedObjectRef _Subclassification;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_PEDefault")]
    protected Primitive<bool> _PEDefault;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Owner")]
    protected NamedObjectRef _Owner;

    public override bool Equals(object obj)
    {
      return obj is EventClassSpecMapChanges && object.Equals((object) this._FailureModeGroup, (object) ((EventClassSpecMapChanges) obj)._FailureModeGroup) && (object.Equals((object) this._Role, (object) ((EventClassSpecMapChanges) obj)._Role) && object.Equals((object) this._ListItemToChange, (object) ((EventClassSpecMapChanges) obj)._ListItemToChange)) && (object.Equals((object) this._Classification, (object) ((EventClassSpecMapChanges) obj)._Classification) && object.Equals((object) this._ObjectToChange, (object) ((EventClassSpecMapChanges) obj)._ObjectToChange) && (object.Equals((object) this._ChecklistTemplate, (object) ((EventClassSpecMapChanges) obj)._ChecklistTemplate) && object.Equals((object) this._Subclassification, (object) ((EventClassSpecMapChanges) obj)._Subclassification))) && (object.Equals((object) this._PEDefault, (object) ((EventClassSpecMapChanges) obj)._PEDefault) && object.Equals((object) this._IsFrozen, (object) ((EventClassSpecMapChanges) obj)._IsFrozen) && object.Equals((object) this._Owner, (object) ((EventClassSpecMapChanges) obj)._Owner)) && base.Equals(obj);
    }

    public NamedObjectRef FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public NamedObjectRef Subclassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Subclassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Subclassification));
      }
    }

    public Primitive<bool> PEDefault
    {
      [param: In] set
      {
        this.PropertySet(nameof (PEDefault), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (PEDefault));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }
  }
}

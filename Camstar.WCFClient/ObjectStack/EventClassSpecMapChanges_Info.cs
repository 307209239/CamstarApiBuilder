// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventClassSpecMapChanges_Info
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
  public class EventClassSpecMapChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_FailureModeGroup")]
    protected Info _FailureModeGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_Subclassification")]
    protected Info _Subclassification;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_PEDefault")]
    protected Info _PEDefault;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "EventClassSpecMapChanges_Info_Owner")]
    protected Info _Owner;

    public Info FailureModeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModeGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureModeGroup));
      }
    }

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public Info Subclassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Subclassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Subclassification));
      }
    }

    public Info PEDefault
    {
      [param: In] set
      {
        this.PropertySet(nameof (PEDefault), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PEDefault));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }
  }
}

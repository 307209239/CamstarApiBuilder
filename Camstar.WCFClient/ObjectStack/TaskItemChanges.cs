// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskItemChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (InstructionItemChanges))]
  [KnownType(typeof (ComputationItemChanges))]
  [KnownType(typeof (TransactionItemChanges))]
  [Serializable]
  public class TaskItemChanges : ProcessItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_ESigRequirement")]
    protected new NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_PrerequisiteTasks")]
    protected new NamedSubentityRef[] _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_InstructionType")]
    protected Enumeration<InstructionTypeEnum, int> _InstructionType;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_StartTimerTaskDtl")]
    protected StartTimerTaskDtlChanges[] _StartTimerTaskDtl;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_EndTimerTaskDtl")]
    protected EndTimerTaskDtlChanges[] _EndTimerTaskDtl;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TaskItemChanges && object.Equals((object) this._ESigRequirement, (object) ((TaskItemChanges) obj)._ESigRequirement) && (this.CompareArrays((Array) this._PrerequisiteTasks, (Array) ((TaskItemChanges) obj)._PrerequisiteTasks) && object.Equals((object) this._ListItemToChange, (object) ((TaskItemChanges) obj)._ListItemToChange)) && (object.Equals((object) this._InstructionType, (object) ((TaskItemChanges) obj)._InstructionType) && object.Equals((object) this._ObjectToChange, (object) ((TaskItemChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._StartTimerTaskDtl, (Array) ((TaskItemChanges) obj)._StartTimerTaskDtl) && this.CompareArrays((Array) this._EndTimerTaskDtl, (Array) ((TaskItemChanges) obj)._EndTimerTaskDtl))) && (object.Equals((object) this._DocumentSet, (object) ((TaskItemChanges) obj)._DocumentSet) && object.Equals((object) this._Name, (object) ((TaskItemChanges) obj)._Name)) && base.Equals(obj);
    }

    public new NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new NamedSubentityRef[] PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Enumeration<InstructionTypeEnum, int> InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Enumeration<InstructionTypeEnum, int>) this.PropertyGet(nameof (InstructionType));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public StartTimerTaskDtlChanges[] StartTimerTaskDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerTaskDtl), (object) value);
      }
      get
      {
        return (StartTimerTaskDtlChanges[]) this.PropertyGet(nameof (StartTimerTaskDtl));
      }
    }

    public EndTimerTaskDtlChanges[] EndTimerTaskDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerTaskDtl), (object) value);
      }
      get
      {
        return (EndTimerTaskDtlChanges[]) this.PropertyGet(nameof (EndTimerTaskDtl));
      }
    }

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}

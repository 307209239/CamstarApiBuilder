// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeItemChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (RecipeIssueItemChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class RecipeItemChanges : ProcessItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_TaskType")]
    protected new Enumeration<TaskTypeEnum, int> _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Sequence")]
    protected new Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_TaskUsage")]
    protected new Enumeration<TaskUsageEnum, int> _TaskUsage;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_PrerequisiteTasks")]
    protected new NamedSubentityRef[] _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;

    public override bool Equals(object obj)
    {
      return obj is RecipeItemChanges && object.Equals((object) this._TaskType, (object) ((RecipeItemChanges) obj)._TaskType) && (object.Equals((object) this._Sequence, (object) ((RecipeItemChanges) obj)._Sequence) && object.Equals((object) this._ObjectToChange, (object) ((RecipeItemChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ListItemToChange, (object) ((RecipeItemChanges) obj)._ListItemToChange) && object.Equals((object) this._TaskUsage, (object) ((RecipeItemChanges) obj)._TaskUsage) && (this.CompareArrays((Array) this._PrerequisiteTasks, (Array) ((RecipeItemChanges) obj)._PrerequisiteTasks) && object.Equals((object) this._Name, (object) ((RecipeItemChanges) obj)._Name))) && object.Equals((object) this._DocumentSet, (object) ((RecipeItemChanges) obj)._DocumentSet) && base.Equals(obj);
    }

    public new Enumeration<TaskTypeEnum, int> TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Enumeration<TaskTypeEnum, int>) this.PropertyGet(nameof (TaskType));
      }
    }

    public new Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
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

    public new Enumeration<TaskUsageEnum, int> TaskUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskUsage), (object) value);
      }
      get
      {
        return (Enumeration<TaskUsageEnum, int>) this.PropertyGet(nameof (TaskUsage));
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
  }
}

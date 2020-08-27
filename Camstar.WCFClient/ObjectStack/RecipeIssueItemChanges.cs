// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeIssueItemChanges
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
  public class RecipeIssueItemChanges : RecipeItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_TaskType")]
    protected new Enumeration<TaskTypeEnum, int> _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Sequence")]
    protected new Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_ManualWeighESigRequirement")]
    protected NamedObjectRef _ManualWeighESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_RecipeMaterialListItem")]
    protected RecipeMaterialListItemChanges _RecipeMaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Scales")]
    protected NamedObjectRef _Scales;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_UseMaterialFromBatch")]
    protected Primitive<bool> _UseMaterialFromBatch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_AllowManualWeighOverride")]
    protected Primitive<bool> _AllowManualWeighOverride;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_IsManualReadingOnly")]
    protected Primitive<bool> _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is RecipeIssueItemChanges && object.Equals((object) this._TaskType, (object) ((RecipeIssueItemChanges) obj)._TaskType) && (object.Equals((object) this._Sequence, (object) ((RecipeIssueItemChanges) obj)._Sequence) && object.Equals((object) this._ManualWeighESigRequirement, (object) ((RecipeIssueItemChanges) obj)._ManualWeighESigRequirement)) && (object.Equals((object) this._RecipeMaterialListItem, (object) ((RecipeIssueItemChanges) obj)._RecipeMaterialListItem) && object.Equals((object) this._ObjectToChange, (object) ((RecipeIssueItemChanges) obj)._ObjectToChange) && (object.Equals((object) this._Scales, (object) ((RecipeIssueItemChanges) obj)._Scales) && object.Equals((object) this._ListItemToChange, (object) ((RecipeIssueItemChanges) obj)._ListItemToChange))) && (object.Equals((object) this._UseMaterialFromBatch, (object) ((RecipeIssueItemChanges) obj)._UseMaterialFromBatch) && object.Equals((object) this._AllowManualWeighOverride, (object) ((RecipeIssueItemChanges) obj)._AllowManualWeighOverride) && (object.Equals((object) this._IsManualReadingOnly, (object) ((RecipeIssueItemChanges) obj)._IsManualReadingOnly) && object.Equals((object) this._Name, (object) ((RecipeIssueItemChanges) obj)._Name))) && base.Equals(obj);
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

    public NamedObjectRef ManualWeighESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ManualWeighESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ManualWeighESigRequirement));
      }
    }

    public RecipeMaterialListItemChanges RecipeMaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeMaterialListItem), (object) value);
      }
      get
      {
        return (RecipeMaterialListItemChanges) this.PropertyGet(nameof (RecipeMaterialListItem));
      }
    }

    public new NamedSubentityRef ObjectToChange
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

    public NamedObjectRef Scales
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scales), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Scales));
      }
    }

    public new NamedSubentityRef ListItemToChange
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

    public Primitive<bool> UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Primitive<bool> AllowManualWeighOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowManualWeighOverride), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowManualWeighOverride));
      }
    }

    public Primitive<bool> IsManualReadingOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManualReadingOnly), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsManualReadingOnly));
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

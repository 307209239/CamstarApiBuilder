// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeIssueItemChanges_Info
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
  public class RecipeIssueItemChanges_Info : RecipeItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_TaskType")]
    protected new Info _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_Sequence")]
    protected new Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_ManualWeighESigRequirement")]
    protected Info _ManualWeighESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_RecipeMaterialListItem")]
    protected RecipeMaterialListItemChanges_Info _RecipeMaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_Scales")]
    protected Info _Scales;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_UseMaterialFromBatch")]
    protected Info _UseMaterialFromBatch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_AllowManualWeighOverride")]
    protected Info _AllowManualWeighOverride;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_IsManualReadingOnly")]
    protected Info _IsManualReadingOnly;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Info_Name")]
    protected new Info _Name;

    public new Info TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskType));
      }
    }

    public new Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info ManualWeighESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ManualWeighESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ManualWeighESigRequirement));
      }
    }

    public RecipeMaterialListItemChanges_Info RecipeMaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeMaterialListItem), (object) value);
      }
      get
      {
        return (RecipeMaterialListItemChanges_Info) this.PropertyGet(nameof (RecipeMaterialListItem));
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

    public Info Scales
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scales), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Scales));
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

    public Info UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Info AllowManualWeighOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowManualWeighOverride), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowManualWeighOverride));
      }
    }

    public Info IsManualReadingOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManualReadingOnly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsManualReadingOnly));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}

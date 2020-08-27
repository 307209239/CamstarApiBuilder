// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessOverrideChanges_Info
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
  public class BillOfProcessOverrideChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_ESigTxnMap")]
    protected ContainerESigTxnMapChanges_Info _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_ElectronicProcedure")]
    protected Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_TxnMap")]
    protected TxnMapChanges_Info _TxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_LabelTxnMap")]
    protected ContainerLabelMapChanges_Info _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_SpecDescription")]
    protected Info _SpecDescription;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_RecipeFile")]
    protected Info _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_Setup")]
    protected Info _Setup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverrideChanges_Info_Name")]
    protected new Info _Name;

    public ContainerESigTxnMapChanges_Info ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMapChanges_Info) this.PropertyGet(nameof (ESigTxnMap));
      }
    }

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
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

    public Info ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public TxnMapChanges_Info TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMapChanges_Info) this.PropertyGet(nameof (TxnMap));
      }
    }

    public ContainerLabelMapChanges_Info LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMapChanges_Info) this.PropertyGet(nameof (LabelTxnMap));
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

    public Info SpecDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecDescription));
      }
    }

    public Info RecipeFile
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeFile), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeFile));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Info Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Setup));
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

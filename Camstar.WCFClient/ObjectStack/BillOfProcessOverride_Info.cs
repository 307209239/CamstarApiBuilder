// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BillOfProcessOverride_Info
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
  public class BillOfProcessOverride_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_ESigTxnMap")]
    protected ContainerESigTxnMap_Info _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_ElectronicProcedure")]
    protected Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_LabelTxnMap")]
    protected ContainerLabelMap_Info _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_TxnMap")]
    protected TxnMap_Info _TxnMap;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_RecipeFile")]
    protected Info _RecipeFile;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_Setup")]
    protected Info _Setup;
    [DataMember(EmitDefaultValue = false, Name = "BillOfProcessOverride_Info_IsFrozen")]
    protected new Info _IsFrozen;

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

    public ContainerESigTxnMap_Info ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (ContainerESigTxnMap_Info) this.PropertyGet(nameof (ESigTxnMap));
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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public ContainerLabelMap_Info LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (ContainerLabelMap_Info) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public TxnMap_Info TxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnMap), (object) value);
      }
      get
      {
        return (TxnMap_Info) this.PropertyGet(nameof (TxnMap));
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

    public new Info IsFrozen
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
  }
}

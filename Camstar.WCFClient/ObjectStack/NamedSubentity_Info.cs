// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedSubentity_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ApprovalSheet_Info))]
  [KnownType(typeof (MaterialListItemSettings_Info))]
  [KnownType(typeof (Step_Info))]
  [KnownType(typeof (HistViewDtl_Info))]
  [KnownType(typeof (AttachedDoc_Info))]
  [KnownType(typeof (DocumentEntry_Info))]
  [KnownType(typeof (UIAction_Info))]
  [KnownType(typeof (Path_Info))]
  [KnownType(typeof (ProcessObject_Info))]
  [KnownType(typeof (BillOfProcessOverride_Info))]
  [KnownType(typeof (DataPointCollection_Info))]
  [KnownType(typeof (Bin_Info))]
  [KnownType(typeof (DataPointCollectionGroup_Info))]
  [KnownType(typeof (DataPoint_Info))]
  [KnownType(typeof (MaterialListItem_Info))]
  [KnownType(typeof (DPCollectionPointSample_Info))]
  [KnownType(typeof (UserAttribute_Info))]
  [KnownType(typeof (Checklist_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChecklistEntry_Info))]
  [KnownType(typeof (UIPrefFieldDef_Info))]
  [KnownType(typeof (BusinessRuleData_Info))]
  [Serializable]
  public class NamedSubentity_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Info Name
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
  }
}

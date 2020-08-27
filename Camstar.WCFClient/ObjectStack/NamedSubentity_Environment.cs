// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedSubentity_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ApprovalSheet_Environment))]
  [KnownType(typeof (Bin_Environment))]
  [KnownType(typeof (UIPrefFieldDef_Environment))]
  [KnownType(typeof (MaterialListItem_Environment))]
  [KnownType(typeof (ProcessObject_Environment))]
  [KnownType(typeof (MaterialListItemSettings_Environment))]
  [KnownType(typeof (DocumentEntry_Environment))]
  [KnownType(typeof (DataPointCollection_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (Step_Environment))]
  [KnownType(typeof (DataPointCollectionGroup_Environment))]
  [KnownType(typeof (UserAttribute_Environment))]
  [KnownType(typeof (AttachedDoc_Environment))]
  [KnownType(typeof (DataPoint_Environment))]
  [KnownType(typeof (UIAction_Environment))]
  [KnownType(typeof (Path_Environment))]
  [KnownType(typeof (DPCollectionPointSample_Environment))]
  [KnownType(typeof (BusinessRuleData_Environment))]
  [KnownType(typeof (BillOfProcessOverride_Environment))]
  [KnownType(typeof (Checklist_Environment))]
  [KnownType(typeof (HistViewDtl_Environment))]
  [KnownType(typeof (ChecklistEntry_Environment))]
  [Serializable]
  public class NamedSubentity_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16777762, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050246, false, false, false, null)]
    protected Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}

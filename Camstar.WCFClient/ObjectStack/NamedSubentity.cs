// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedSubentity
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (BillOfProcessOverride))]
  [KnownType(typeof (ApprovalSheet))]
  [KnownType(typeof (MaterialListItemSettings))]
  [KnownType(typeof (BusinessRuleData))]
  [KnownType(typeof (DocumentEntry))]
  [KnownType(typeof (HistViewDtl))]
  [KnownType(typeof (UIPrefFieldDef))]
  [KnownType(typeof (Step))]
  [KnownType(typeof (Path))]
  [KnownType(typeof (Bin))]
  [KnownType(typeof (MaterialListItem))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (AttachedDoc))]
  [KnownType(typeof (UserAttribute))]
  [KnownType(typeof (UIAction))]
  [KnownType(typeof (ProcessObject))]
  [KnownType(typeof (DataPointCollection))]
  [KnownType(typeof (DataPointCollectionGroup))]
  [KnownType(typeof (DataPoint))]
  [KnownType(typeof (DPCollectionPointSample))]
  [KnownType(typeof (Checklist))]
  [KnownType(typeof (ChecklistEntry))]
  [Serializable]
  public class NamedSubentity : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedSubentity_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is NamedSubentity && object.Equals((object) this._ExportImportKey, (object) ((NamedSubentity) obj)._ExportImportKey) && (object.Equals((object) this._DisplayName, (object) ((NamedSubentity) obj)._DisplayName) && object.Equals((object) this._Name, (object) ((NamedSubentity) obj)._Name)) && object.Equals((object) this._IsFrozen, (object) ((NamedSubentity) obj)._IsFrozen) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Primitive<string> Name
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
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelTxnMapChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (PELabelMapChanges))]
  [KnownType(typeof (RecipeLabelMapChanges))]
  [KnownType(typeof (ContainerLabelMapChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (NCRLabelMapChanges))]
  [KnownType(typeof (QualityObjectLabelMapChanges))]
  [Serializable]
  public class LabelTxnMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_LabelCount")]
    protected Primitive<string> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_PrinterLabelDefinition")]
    protected RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_Parent")]
    protected new BaseObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_TxnType")]
    protected Primitive<int> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is LabelTxnMapChanges && object.Equals((object) this._LabelCount, (object) ((LabelTxnMapChanges) obj)._LabelCount) && (object.Equals((object) this._PrinterLabelDefinition, (object) ((LabelTxnMapChanges) obj)._PrinterLabelDefinition) && object.Equals((object) this._ObjectToChange, (object) ((LabelTxnMapChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ListItemToChange, (object) ((LabelTxnMapChanges) obj)._ListItemToChange) && object.Equals((object) this._Parent, (object) ((LabelTxnMapChanges) obj)._Parent) && (object.Equals((object) this._TxnType, (object) ((LabelTxnMapChanges) obj)._TxnType) && object.Equals((object) this._IsFrozen, (object) ((LabelTxnMapChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public Primitive<string> LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelCount));
      }
    }

    public RevisionedObjectRef PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new BaseObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Parent));
      }
    }

    public Primitive<int> TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnType));
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

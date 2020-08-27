// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityTxn
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
  public class QualityTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_DataCollectionDef")]
    protected new RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_AvailableActions")]
    protected Enumeration<QualityRecordActionsEnum, int> _AvailableActions;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_QualityESigDetail")]
    protected QualityESigDetail _QualityESigDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_QualityObjectDetail")]
    protected QualityObjectStatusDetail _QualityObjectDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_IgnoreProcessModel")]
    protected Primitive<bool> _IgnoreProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;

    public override bool Equals(object obj)
    {
      return obj is QualityTxn && object.Equals((object) this._Comments, (object) ((QualityTxn) obj)._Comments) && (object.Equals((object) this._DataCollectionDef, (object) ((QualityTxn) obj)._DataCollectionDef) && object.Equals((object) this._QualityObject, (object) ((QualityTxn) obj)._QualityObject)) && (object.Equals((object) this._AvailableActions, (object) ((QualityTxn) obj)._AvailableActions) && object.Equals((object) this._QualityESigDetail, (object) ((QualityTxn) obj)._QualityESigDetail) && (object.Equals((object) this._Organization, (object) ((QualityTxn) obj)._Organization) && object.Equals((object) this._QualityObjectDetail, (object) ((QualityTxn) obj)._QualityObjectDetail))) && (object.Equals((object) this._IgnoreProcessModel, (object) ((QualityTxn) obj)._IgnoreProcessModel) && object.Equals((object) this._ProcessESignatures, (object) ((QualityTxn) obj)._ProcessESignatures)) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public new RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Enumeration<QualityRecordActionsEnum, int> AvailableActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableActions), (object) value);
      }
      get
      {
        return (Enumeration<QualityRecordActionsEnum, int>) this.PropertyGet(nameof (AvailableActions));
      }
    }

    public QualityESigDetail QualityESigDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigDetail), (object) value);
      }
      get
      {
        return (QualityESigDetail) this.PropertyGet(nameof (QualityESigDetail));
      }
    }

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public QualityObjectStatusDetail QualityObjectDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail) this.PropertyGet(nameof (QualityObjectDetail));
      }
    }

    public Primitive<bool> IgnoreProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (IgnoreProcessModel), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IgnoreProcessModel));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }
  }
}

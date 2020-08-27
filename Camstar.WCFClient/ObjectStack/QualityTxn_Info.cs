// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityTxn_Info
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
  public class QualityTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_DataCollectionDef")]
    protected new Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_AvailableActions")]
    protected Info _AvailableActions;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_QualityESigDetail")]
    protected QualityESigDetail_Info _QualityESigDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_QualityObjectDetail")]
    protected QualityObjectStatusDetail_Info _QualityObjectDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_IgnoreProcessModel")]
    protected Info _IgnoreProcessModel;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Info_ProcessESignatures")]
    protected new Info _ProcessESignatures;

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public new Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Info AvailableActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableActions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AvailableActions));
      }
    }

    public QualityESigDetail_Info QualityESigDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigDetail), (object) value);
      }
      get
      {
        return (QualityESigDetail_Info) this.PropertyGet(nameof (QualityESigDetail));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public QualityObjectStatusDetail_Info QualityObjectDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Info) this.PropertyGet(nameof (QualityObjectDetail));
      }
    }

    public Info IgnoreProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (IgnoreProcessModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IgnoreProcessModel));
      }
    }

    public new Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityTxn_Environment
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
  public class QualityTxn_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, false, false, "RevisionedObjectRef", 1048868, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_DataCollectionDef")]
    protected new Environment _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_QualityObject")]
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected Environment _QualityObject;
    [Metadata("Enumeration for the Quality Record Actions:\r\n0 = None\r\n1 = View\r\n2 = Edit\r\n4 = ChangeOwner\r\n8 = ChangeCategory\r\n16 = Triage\r\n32 = InitiateCAR\r\n64 = Resolve\r\n128 = AssignProcessModel\r\n256 = CancelApproval\r\n", "QualityRecordActionsEnum", false, false, true, "Integer", 1052079, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_AvailableActions")]
    protected Environment _AvailableActions;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_QualityESigDetail")]
    [Metadata("The QualityESigDetail is used to collect Electronic Signature for any QualityTxn service. ", "QualityESigDetail", false, false, false, "QualityESigDetail", 1051664, false, false, false, null)]
    protected QualityESigDetail_Environment _QualityESigDetail;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_Organization")]
    protected Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_QualityObjectDetail")]
    [Metadata("The detail information for the QualityObject.", "QualityObjectStatusDetail", false, false, true, "QualityObjectStatusDetail", 1051467, false, false, false, null)]
    protected QualityObjectStatusDetail_Environment _QualityObjectDetail;
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_IgnoreProcessModel")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053041, false, false, false, "0")]
    protected Environment _IgnoreProcessModel;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "QualityTxn_Environment_ProcessESignatures")]
    protected new Environment _ProcessESignatures;

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Environment AvailableActions
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableActions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AvailableActions));
      }
    }

    public QualityESigDetail_Environment QualityESigDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigDetail), (object) value);
      }
      get
      {
        return (QualityESigDetail_Environment) this.PropertyGet(nameof (QualityESigDetail));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public QualityObjectStatusDetail_Environment QualityObjectDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObjectDetail), (object) value);
      }
      get
      {
        return (QualityObjectStatusDetail_Environment) this.PropertyGet(nameof (QualityObjectDetail));
      }
    }

    public Environment IgnoreProcessModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (IgnoreProcessModel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IgnoreProcessModel));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }
  }
}

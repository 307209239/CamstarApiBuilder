// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalTxn_Environment
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
  public class ApprovalTxn_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [Metadata("An approval sheet is used to collect signatures of approvers to indicate acceptance or rejection of an object\r\n", "ApprovalSheet", false, false, false, "NamedSubentityRef", 1051639, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Environment_ApprovalSheet")]
    protected Environment _ApprovalSheet;
    [Metadata("Detail information about a change package.", "ChangePackageHeader", false, false, true, "ChangePackageHeader", 1053248, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Environment_ChangePackageHeader")]
    protected ChangePackageHeader_Environment _ChangePackageHeader;
    [Metadata("BaseObject", "BaseObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Environment_TrackableObject")]
    protected Environment _TrackableObject;

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

    public Environment ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public ChangePackageHeader_Environment ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Environment) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }
  }
}

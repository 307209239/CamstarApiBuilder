// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalTxn_Info
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
  public class ApprovalTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Info_ApprovalSheet")]
    protected Info _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Info_ChangePackageHeader")]
    protected ChangePackageHeader_Info _ChangePackageHeader;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalTxn_Info_TrackableObject")]
    protected Info _TrackableObject;

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

    public Info ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public ChangePackageHeader_Info ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Info) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }
  }
}

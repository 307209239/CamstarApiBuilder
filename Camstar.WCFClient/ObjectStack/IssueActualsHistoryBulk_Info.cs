// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryBulk_Info
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
  public class IssueActualsHistoryBulk_Info : IssueActualsHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Info_FromCarrier")]
    protected Info _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Info_FromBatch")]
    protected Info _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Info_IssuedFrom")]
    protected new Info _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Info_FromContainer")]
    protected Info _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_Info_FromLocation")]
    protected Info _FromLocation;

    public Info FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public Info FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromBatch));
      }
    }

    public new Info IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Info FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Info FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromLocation));
      }
    }
  }
}

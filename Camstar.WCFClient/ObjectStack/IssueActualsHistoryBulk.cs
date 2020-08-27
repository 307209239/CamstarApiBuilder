// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryBulk
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
  public class IssueActualsHistoryBulk : IssueActualsHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_FromCarrier")]
    protected NamedObjectRef _FromCarrier;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_FromBatch")]
    protected ContainerRef _FromBatch;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_IssuedFrom")]
    protected new Primitive<string> _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_FromContainer")]
    protected ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryBulk_FromLocation")]
    protected NamedSubentityRef _FromLocation;

    public override bool Equals(object obj)
    {
      return obj is IssueActualsHistoryBulk && object.Equals((object) this._FromCarrier, (object) ((IssueActualsHistoryBulk) obj)._FromCarrier) && (object.Equals((object) this._FromBatch, (object) ((IssueActualsHistoryBulk) obj)._FromBatch) && object.Equals((object) this._IssuedFrom, (object) ((IssueActualsHistoryBulk) obj)._IssuedFrom)) && (object.Equals((object) this._FromContainer, (object) ((IssueActualsHistoryBulk) obj)._FromContainer) && object.Equals((object) this._FromLocation, (object) ((IssueActualsHistoryBulk) obj)._FromLocation)) && base.Equals(obj);
    }

    public NamedObjectRef FromCarrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCarrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromCarrier));
      }
    }

    public ContainerRef FromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromBatch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromBatch));
      }
    }

    public new Primitive<string> IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public ContainerRef FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromContainer));
      }
    }

    public NamedSubentityRef FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (FromLocation));
      }
    }
  }
}

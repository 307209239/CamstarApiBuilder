// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkStatusStartDetails
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
  public class ReworkStatusStartDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatusStartDetails_ReEntryStep")]
    protected NamedSubentityRef _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatusStartDetails_EndReworkStep")]
    protected NamedSubentityRef _EndReworkStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatusStartDetails_ReworkReason")]
    protected NamedObjectRef _ReworkReason;

    public override bool Equals(object obj)
    {
      return obj is ReworkStatusStartDetails && object.Equals((object) this._ReEntryStep, (object) ((ReworkStatusStartDetails) obj)._ReEntryStep) && (object.Equals((object) this._EndReworkStep, (object) ((ReworkStatusStartDetails) obj)._EndReworkStep) && object.Equals((object) this._ReworkReason, (object) ((ReworkStatusStartDetails) obj)._ReworkReason)) && base.Equals(obj);
    }

    public NamedSubentityRef ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public NamedSubentityRef EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (EndReworkStep));
      }
    }

    public NamedObjectRef ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReason));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDataHistoryDetails
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
  public class FailureDataHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_FailureType")]
    protected NamedObjectRef _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_FailureSeverity")]
    protected NamedObjectRef _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_CauseHistoryDetails")]
    protected FailureCauseDataHistoryDetails[] _CauseHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "FailureDataHistoryDetails_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is FailureDataHistoryDetails && object.Equals((object) this._FailureType, (object) ((FailureDataHistoryDetails) obj)._FailureType) && (object.Equals((object) this._FailureSeverity, (object) ((FailureDataHistoryDetails) obj)._FailureSeverity) && object.Equals((object) this._FailureMode, (object) ((FailureDataHistoryDetails) obj)._FailureMode)) && (this.CompareArrays((Array) this._CauseHistoryDetails, (Array) ((FailureDataHistoryDetails) obj)._CauseHistoryDetails) && object.Equals((object) this._Description, (object) ((FailureDataHistoryDetails) obj)._Description)) && base.Equals(obj);
    }

    public NamedObjectRef FailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureType));
      }
    }

    public NamedObjectRef FailureSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureSeverity), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureSeverity));
      }
    }

    public NamedObjectRef FailureMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureMode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FailureMode));
      }
    }

    public FailureCauseDataHistoryDetails[] CauseHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseHistoryDetails), (object) value);
      }
      get
      {
        return (FailureCauseDataHistoryDetails[]) this.PropertyGet(nameof (CauseHistoryDetails));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}

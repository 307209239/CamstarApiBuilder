// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureDetails
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
  public class FailureDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_FailureType")]
    protected NamedObjectRef _FailureType;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_FailureMode")]
    protected NamedObjectRef _FailureMode;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_FailureSeverity")]
    protected NamedObjectRef _FailureSeverity;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Causes")]
    protected FailureCauseDetails[] _Causes;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_FailureData")]
    protected SubentityRef _FailureData;
    [DataMember(EmitDefaultValue = false, Name = "FailureDetails_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is FailureDetails && object.Equals((object) this._FailureType, (object) ((FailureDetails) obj)._FailureType) && (object.Equals((object) this._FailureMode, (object) ((FailureDetails) obj)._FailureMode) && object.Equals((object) this._FailureSeverity, (object) ((FailureDetails) obj)._FailureSeverity)) && (this.CompareArrays((Array) this._Causes, (Array) ((FailureDetails) obj)._Causes) && object.Equals((object) this._FailureData, (object) ((FailureDetails) obj)._FailureData) && object.Equals((object) this._Description, (object) ((FailureDetails) obj)._Description)) && base.Equals(obj);
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

    public FailureCauseDetails[] Causes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Causes), (object) value);
      }
      get
      {
        return (FailureCauseDetails[]) this.PropertyGet(nameof (Causes));
      }
    }

    public SubentityRef FailureData
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (FailureData));
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

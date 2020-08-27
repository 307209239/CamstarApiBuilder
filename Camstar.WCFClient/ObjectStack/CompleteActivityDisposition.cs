// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityDisposition
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
  public class CompleteActivityDisposition : CompleteActivity
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_ServiceDetails")]
    protected DispositionDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Activity")]
    protected new NamedSubentityRef _Activity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_ProcessObjectDetails")]
    protected ActivityDisposition _ProcessObjectDetails;

    public override bool Equals(object obj)
    {
      return obj is CompleteActivityDisposition && this.CompareArrays((Array) this._ServiceDetails, (Array) ((CompleteActivityDisposition) obj)._ServiceDetails) && (object.Equals((object) this._ProcessObject, (object) ((CompleteActivityDisposition) obj)._ProcessObject) && object.Equals((object) this._Activity, (object) ((CompleteActivityDisposition) obj)._Activity)) && (object.Equals((object) this._Disposition, (object) ((CompleteActivityDisposition) obj)._Disposition) && object.Equals((object) this._ProcessObjectDetails, (object) ((CompleteActivityDisposition) obj)._ProcessObjectDetails)) && base.Equals(obj);
    }

    public DispositionDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DispositionDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new NamedSubentityRef Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Activity));
      }
    }

    public NamedObjectRef Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Disposition));
      }
    }

    public ActivityDisposition ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ActivityDisposition) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}

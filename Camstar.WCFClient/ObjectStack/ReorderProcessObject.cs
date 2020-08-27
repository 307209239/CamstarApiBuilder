// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReorderProcessObject
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
  public class ReorderProcessObject : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObject_ServiceDetails")]
    protected ReorderProcessObjectDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObject_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;

    public override bool Equals(object obj)
    {
      return obj is ReorderProcessObject && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ReorderProcessObject) obj)._ServiceDetails) && object.Equals((object) this._ProcessObject, (object) ((ReorderProcessObject) obj)._ProcessObject) && base.Equals(obj);
    }

    public ReorderProcessObjectDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ReorderProcessObjectDetail[]) this.PropertyGet(nameof (ServiceDetails));
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
  }
}

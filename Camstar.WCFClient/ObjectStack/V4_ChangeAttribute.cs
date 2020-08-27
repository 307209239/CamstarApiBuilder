// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_ChangeAttribute
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
  public class V4_ChangeAttribute : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_ContainerStatusDetails")]
    protected ChangeAttributeAsParent _ContainerStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_ServiceDetails")]
    protected ChangeAttributeDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "V4_ChangeAttribute_IncludeChildren")]
    protected Primitive<int> _IncludeChildren;

    public override bool Equals(object obj)
    {
      return obj is V4_ChangeAttribute && object.Equals((object) this._ContainerStatusDetails, (object) ((V4_ChangeAttribute) obj)._ContainerStatusDetails) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((V4_ChangeAttribute) obj)._ServiceDetails) && object.Equals((object) this._IncludeChildren, (object) ((V4_ChangeAttribute) obj)._IncludeChildren)) && base.Equals(obj);
    }

    public ChangeAttributeAsParent ContainerStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeAsParent) this.PropertyGet(nameof (ContainerStatusDetails));
      }
    }

    public ChangeAttributeDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChangeAttributeDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<int> IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}

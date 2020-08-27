// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceActivationDetails
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
  public class ResourceActivationDetails : MaintReqActivationDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_ClassActivated")]
    protected Primitive<bool> _ClassActivated;
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_ResourceName")]
    protected Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceActivationDetails_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is ResourceActivationDetails && object.Equals((object) this._ClassActivated, (object) ((ResourceActivationDetails) obj)._ClassActivated) && (object.Equals((object) this._ResourceName, (object) ((ResourceActivationDetails) obj)._ResourceName) && object.Equals((object) this._Resource, (object) ((ResourceActivationDetails) obj)._Resource)) && base.Equals(obj);
    }

    public Primitive<bool> ClassActivated
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClassActivated), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ClassActivated));
      }
    }

    public Primitive<string> ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResourceName));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }
  }
}

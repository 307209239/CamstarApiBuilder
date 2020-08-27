// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialContainerStart
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
  public class MaterialContainerStart : Start
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_CurrentStatusDetails")]
    protected MatlContainerCurrentStartDtls _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Details")]
    protected MaterialContainerStartDetails _Details;

    public override bool Equals(object obj)
    {
      return obj is MaterialContainerStart && object.Equals((object) this._CurrentStatusDetails, (object) ((MaterialContainerStart) obj)._CurrentStatusDetails) && (object.Equals((object) this._Container, (object) ((MaterialContainerStart) obj)._Container) && object.Equals((object) this._Details, (object) ((MaterialContainerStart) obj)._Details)) && base.Equals(obj);
    }

    public MatlContainerCurrentStartDtls CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (MatlContainerCurrentStartDtls) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public MaterialContainerStartDetails Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (MaterialContainerStartDetails) this.PropertyGet(nameof (Details));
      }
    }
  }
}

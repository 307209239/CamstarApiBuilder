// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialContainerStart_Environment
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
  public class MaterialContainerStart_Environment : Start_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Environment_CurrentStatusDetails")]
    [Metadata("Material Container Current Start Details", "MatlContainerCurrentStartDtls", false, false, false, "MatlContainerCurrentStartDtls", 1049869, true, false, false, null)]
    protected MatlContainerCurrentStartDtls_Environment _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Environment_Container")]
    [Metadata("Material Container", "MaterialContainer", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [Metadata("Start Details required for creating Material Containers.", "MaterialContainerStartDetails", false, true, false, "MaterialContainerStartDetails", 1049090, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Environment_Details")]
    protected MaterialContainerStartDetails_Environment _Details;

    public MatlContainerCurrentStartDtls_Environment CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (MatlContainerCurrentStartDtls_Environment) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public MaterialContainerStartDetails_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (MaterialContainerStartDetails_Environment) this.PropertyGet(nameof (Details));
      }
    }
  }
}

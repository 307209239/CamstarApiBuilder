// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialContainerStart_Info
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
  public class MaterialContainerStart_Info : Start_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Info_CurrentStatusDetails")]
    protected MatlContainerCurrentStartDtls_Info _CurrentStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerStart_Info_Details")]
    protected MaterialContainerStartDetails_Info _Details;

    public MatlContainerCurrentStartDtls_Info CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (MatlContainerCurrentStartDtls_Info) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public MaterialContainerStartDetails_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (MaterialContainerStartDetails_Info) this.PropertyGet(nameof (Details));
      }
    }
  }
}

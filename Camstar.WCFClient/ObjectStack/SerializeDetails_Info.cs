// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeDetails_Info
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
  public class SerializeDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Info_StartDetails")]
    protected SerializedStartDetails_Info _StartDetails;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Info_ActualChildCount")]
    protected Info _ActualChildCount;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Info_ChildContainerLevel")]
    protected Info _ChildContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Info_Product")]
    protected Info _Product;
    [DataMember(EmitDefaultValue = false, Name = "SerializeDetails_Info_ContainerNames")]
    protected Info _ContainerNames;

    public SerializedStartDetails_Info StartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDetails), (object) value);
      }
      get
      {
        return (SerializedStartDetails_Info) this.PropertyGet(nameof (StartDetails));
      }
    }

    public Info ActualChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualChildCount));
      }
    }

    public Info ChildContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainerLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildContainerLevel));
      }
    }

    public Info Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Product));
      }
    }

    public Info ContainerNames
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNames), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerNames));
      }
    }
  }
}

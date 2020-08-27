// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeActualSerial_Info
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
  public class CompDistributeActualSerial_Info : ActualsSerial_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_Info_FromContainer")]
    protected new Info _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_Info_ToContainer")]
    protected new Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_Info_FromLocation")]
    protected new Info _FromLocation;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualSerial_Info_ToLocation")]
    protected new Info _ToLocation;

    public new Info FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromContainer));
      }
    }

    public new Info ToContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainer));
      }
    }

    public new Info FromLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromLocation));
      }
    }

    public new Info ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToLocation));
      }
    }
  }
}

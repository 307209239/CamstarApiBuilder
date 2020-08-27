// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeActualBulk_Info
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
  public class CompDistributeActualBulk_Info : ActualsBulk_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Info_Vendor")]
    protected new Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Info_FromContainer")]
    protected new Info _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Info_ToContainer")]
    protected new Info _ToContainer;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Info_ToLocation")]
    protected new Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeActualBulk_Info_FromLocation")]
    protected new Info _FromLocation;

    public new Info Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Vendor));
      }
    }

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
  }
}

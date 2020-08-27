// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveStd_Info
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
  public class MoveStd_Info : MoveTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_Info_Path")]
    protected new Info _Path;
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_Info_Resource")]
    protected new Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_Info_ToStep")]
    protected new Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveStd_Info_Location")]
    protected new Info _Location;

    public new Info Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Path));
      }
    }

    public new Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public new Info ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToStep));
      }
    }

    public new Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }
  }
}

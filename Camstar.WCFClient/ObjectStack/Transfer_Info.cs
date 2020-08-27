// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Transfer_Info
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
  public class Transfer_Info : MoveNonStd_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Info_Close")]
    protected new Info _Close;
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Info_ToLocation")]
    protected new Info _ToLocation;
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Info_ToFactory")]
    protected new Info _ToFactory;

    public new Info Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Close));
      }
    }

    public new Info UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseDispatch));
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

    public new Info ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToFactory));
      }
    }
  }
}

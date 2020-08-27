// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveNonStd_Info
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
  public class MoveNonStd_Info : MoveTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStd_Info_Close")]
    protected new Info _Close;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStd_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStd_Info_ToStep")]
    protected new Info _ToStep;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStd_Info_ToFactory")]
    protected new Info _ToFactory;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStd_Info_ToLocation")]
    protected new Info _ToLocation;

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

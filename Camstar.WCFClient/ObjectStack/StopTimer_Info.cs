﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StopTimer_Info
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
  public class StopTimer_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StopTimer_Info_TimerId")]
    protected Info _TimerId;
    [DataMember(EmitDefaultValue = false, Name = "StopTimer_Info_Comments")]
    protected new Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "StopTimer_Info_Container")]
    protected new Info _Container;

    public Info TimerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimerId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimerId));
      }
    }

    public new Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
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
  }
}

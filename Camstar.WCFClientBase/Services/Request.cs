﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.Request
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Request : WCFObjectBase
  {
    public Info Info
    {
      get
      {
        return (Info) this.PropertyGet(nameof (Info));
      }
      set
      {
        this.PropertySet(nameof (Info), (object) value);
      }
    }
  }
}
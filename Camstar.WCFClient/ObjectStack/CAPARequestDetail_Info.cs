﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPARequestDetail_Info
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
  public class CAPARequestDetail_Info : CAPADetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPARequestDetail_Info_ProposedResolution")]
    protected Info _ProposedResolution;

    public Info ProposedResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProposedResolution), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProposedResolution));
      }
    }
  }
}

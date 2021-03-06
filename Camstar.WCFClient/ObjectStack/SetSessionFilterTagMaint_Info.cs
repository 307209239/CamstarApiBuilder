﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetSessionFilterTagMaint_Info
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
  public class SetSessionFilterTagMaint_Info : EmployeeMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_Info_ObjectChanges")]
    protected SetSessionFilterTagChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_Info_SyncName")]
    protected new Info _SyncName;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public SetSessionFilterTagChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SetSessionFilterTagChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Info SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SyncName));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PackageTypeMaint_Info
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
  public class PackageTypeMaint_Info : UserCodeMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PackageTypeMaint_Info_ObjectChanges")]
    protected PackageTypeChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PackageTypeMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PackageTypeMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public PackageTypeChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PackageTypeChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
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
